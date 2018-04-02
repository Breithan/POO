using System;

namespace LibOPEJamon
{
    public class ClsOPEJamon
    {
        #region Contructor
        public ClsOPEJamon()
        {
            intDiaPed = 0;
            blnEsFest = false;
            blnEsQuinc = false;
            fltCantNorm = 0;
            fltCantAdic = 0;
            fltCantTot = 0;
            fltVrAPag = 0;
            strError = String.Empty;
        }
        #endregion

        #region Atributos
        private int intDiaPed;
        private bool blnEsFest, blnEsQuinc;
        private float fltCantNorm, fltCantAdic, fltCantTot, fltVrAPag;
        private string strError;
        #endregion

        #region Propiedades
        public int DiaPed
        {
            set { intDiaPed = value; }
            get { return intDiaPed; }
        }
        public bool EsFest
        {
            set { blnEsFest = value; }
        }
        public bool EsQuinc
        {
            set { blnEsQuinc = value; }
        }
        public float CantNorm
        {
            get { return fltCantNorm; }
        }
        public float CantAdic
        {
            get { return fltCantTot; }
        }
        public float CantTot
        {
            get { return fltCantTot; }
        }
        public float VrAPag
        {
            get { return fltVrAPag; }
        }
        public string Error
        {
            get { return strError; }
        }
        #endregion

        #region Métodos Privados
        private bool Validar()
        {
            if (intDiaPed < 1 || intDiaPed > 6)
            {
                strError = "Día de pedido no válido";
                return false;
            }
            return true;
        }
        #endregion

        #region Métodos Públicos
        /// <summary>
        /// Retorna los valores a pedir acorde al día del pedido
        /// </summary>
        /// <returns></returns>
        public bool RealizarPedido()
        {

            float fltValorLibra;

            try
            {
                if (!Validar()) return false;

                clsRNPedJamon objRNPedJamon = new clsRNPedJamon();
                objRNPedJamon.dia = intDiaPed;

                if (!objRNPedJamon.hallarDatos())
                {
                    strError = objRNPedJamon.error;
                    objRNPedJamon = null;
                    return false;
                }

                fltCantNorm = objRNPedJamon.cant_norm;
                fltValorLibra = objRNPedJamon.valor_unit;

                if (blnEsFest) fltCantAdic = objRNPedJamon.cant_fest;
                if (blnEsQuinc) fltCantAdic += objRNPedJamon.cant_quin;

                objRNPedJamon = null;
                fltCantTot = fltCantNorm + fltCantAdic;
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
