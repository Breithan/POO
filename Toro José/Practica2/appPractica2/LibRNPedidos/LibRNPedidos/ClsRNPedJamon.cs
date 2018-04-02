using System;
using System.IO;

namespace LibRNPedidos
{
    public class ClsRNPedJamon
    {
        #region "Atributos"
        private int intDia;
        private float fltVr_Unit, fltC_Norm, fltC_Quin, fltC_Fest;
        private string strError;
        #endregion

        #region "Constructor"
        public ClsRNPedJamon()
        {
            intDia = 0;
            fltVr_Unit = 0;
            fltC_Norm = 0;
            fltC_Quin = 0;
            fltC_Fest = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public int dia
        {
            set { intDia = value; }
        }
        public float valor_unit
        {
            get { return fltVr_Unit; }
        }
        public float cant_norm
        {
            get { return fltC_Norm; }
        }
        public float cant_quin
        {
            get { return fltC_Quin; }
        }
        public float cant_fest
        {
            get { return fltC_Fest; }
        }
        public string error
        {
            get { return strError; }
        }
        #endregion

        #region "Metodos Privados"
        private bool leerArchivo()
        {
            try
            {
                int intCant = 0;
                string[] vectorLinea;
                string strLinea;
                string strDia;

                string strDirecc = AppDomain.CurrentDomain.BaseDirectory + @"pedidos.txt";
                intCant = File.ReadAllLines(@strDirecc).Length;
                if (intCant <= 0)
                    return true;

                StreamReader Archivo = new StreamReader(@strDirecc); //Crear objeto para leer el archivo ✿◕‿◕✿ 
                while ((strLinea = Archivo.ReadLine()) != null)   //Leer línea * línea el archivo 
                {
                    vectorLinea = strLinea.Split('|');
                    strDia = vectorLinea[0];
                    if (strDia == intDia.ToString())
                    {
                        fltVr_Unit = Convert.ToSingle(vectorLinea[1]);//Valor
                        fltC_Norm = Convert.ToSingle(vectorLinea[2]);//Cantidad Normal
                        fltC_Quin = Convert.ToSingle(vectorLinea[3]);//Quincena
                        fltC_Fest = Convert.ToSingle(vectorLinea[4]);//Festiva xd
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion

        #region "Metodos Públicos"
        public bool hallarDatos()
        {
            return leerArchivo();
        }
        #endregion
    }
}
