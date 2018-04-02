using System;

namespace LibConvTemp
{
    public class ClsConvTemp
    {
        #region Constructor
        public ClsConvTemp()
        {
            fltGra_C = 0;
            fltGra_F = 0;
            fltGra_K = 0;
            fltGra_R = 0;
            strError = string.Empty;
            strGra_Conv = string.Empty;
        }
        #endregion

        #region Atributos
        private float fltGra_C;
        private float fltGra_F;
        private float fltGra_K;
        private float fltGra_R;
        private string strError;
        private string strGra_Conv;
        #endregion

        #region Propiedades
        public float Gra_C
        {
            set { fltGra_C = value; }
            get { return fltGra_C; }
        }
        public float Gra_F
        {
            set { fltGra_F = value; }
            get { return fltGra_F; }
        }
        public float Gra_K
        {
            set { fltGra_K = value; }
            get { return fltGra_K; }
        }
        public float Gra_R
        {
            set { fltGra_R = value; }
            get { return fltGra_R; }
        }
        public string Error
        {
            get { return strError; }
        }
        public string Gra_Conv
        {
            set { strGra_Conv = value; }
        }
        #endregion

        #region Métodos Públicos
        public bool Convertir()
        {
            try
            {
                if (strGra_Conv == "C")
                {
                    fltGra_F = (1.8f * fltGra_C) + 32;
                    fltGra_K = fltGra_C + 273.15f;
                    fltGra_R = 1.8f * (fltGra_C + 273.15f);
                }

                else if (strGra_Conv == "F")
                {
                    fltGra_C = (fltGra_F - 32) / 1.8f;
                    fltGra_K = 1.8f * (fltGra_F + 459.67f);
                    fltGra_R = fltGra_F + 459.67f;
                }

                else if (strGra_Conv == "K")
                {
                    fltGra_C = fltGra_K - 273.15f;
                    fltGra_F = (1.8f * fltGra_K) - 459.67f;
                    fltGra_R = 1.8f * fltGra_K;
                }

                else if (strGra_Conv == "R")
                {
                    fltGra_C = 1.8f * (fltGra_R - 459.67f);
                    fltGra_F = fltGra_R - 459.67f;
                    fltGra_K = 1.8f * fltGra_R;
                }

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
