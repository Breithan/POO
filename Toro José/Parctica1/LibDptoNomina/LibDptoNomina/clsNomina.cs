using System;

namespace LibDptoNomina
{
    public class clsNomina
    {
        #region "Constructor"
        public clsNomina()
        {
            fltCantHW = 0;
            fltVrHora = 0;
            fltSal_Bruto = 0;
            fltCant_HExt = 0;
            fltVr_Extras = 0;
            fltVr_Rete = 0;
            fltVr_AuxTte = 0;
            fltSal_Neto = 0;
            fltSMLV = 781242;
            fltAuxTot = 83140;
            fltPRete = 0.08f;
            fltCant_HOrd = 0;
            strError = String.Empty;
        }
        #endregion


        #region "Atributos"
        private float fltCantHW;
        private float fltVrHora;
        private float fltSal_Bruto;
        private float fltCant_HExt;
        private float fltVr_Extras;
        private float fltVr_Rete;
        private float fltVr_AuxTte;
        private float fltSal_Neto;
        private float fltSMLV;
        private float fltAuxTot;
        private float fltPRete;
        private float fltCant_HOrd;
        private string strError;
        #endregion


        #region "Propiedades"
        public float CantHW
        {
            set { fltCantHW = value; }
        }

        public float VrHora
        {
            set { fltVrHora = value; }
        }

        public float Sal_Bruto
        {
            get { return fltSal_Bruto; }
        }

        public float Cant_HExt
        {
            get { return fltCant_HExt; }
        }

        public float Vr_Extras
        {
            get { return fltVr_Extras; }
        }

        public float Vr_Rete
        {
            get { return fltVr_Rete; }
        }

        public float Vr_AuxTte
        {
            get { return fltVr_AuxTte; }
        }

        public float Sal_Neto
        {
            get { return fltSal_Neto; }
        }

        public string Error
        {
            get { return strError; }
        }
        #endregion


        #region "Métodos Privados"
        private bool validar()
        {
            if (fltCantHW < 0)
            {
                strError = "Cantidad de Horas Trabajadas no valida";
                return false;
            }

            if (fltVrHora <= 0)
            {
                strError = "Valor de Hora no válida";
                return false;
            }

            return true;
        }
        #endregion


        #region "Métodos Publicos"
        public bool Liquidar()
        {
            try
            {
                if (!validar())
                    return false;

                fltCant_HOrd = fltCantHW;
                if (fltCantHW > 240)
                {
                    fltCant_HExt = fltCantHW - 240;
                    fltCant_HOrd = 240;
                }

                fltVr_Extras = Cant_HExt * fltVrHora * 1.35f;
                fltSal_Bruto = fltVrHora * fltCant_HOrd + fltVr_Extras;
                fltVr_Rete = fltSal_Bruto * fltPRete;

                if (fltVrHora * 240 <= 2 * fltSMLV)
                    fltVr_AuxTte = fltAuxTot;

                fltSal_Neto = fltSal_Bruto - fltVr_Rete + fltVr_AuxTte;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
