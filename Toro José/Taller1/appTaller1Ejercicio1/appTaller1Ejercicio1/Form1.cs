using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibConvTemp;

namespace appTaller1Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Valores Globales
        float fltTemperatura;
        bool bolTempC;
        bool bolTempF;
        bool bolTempK;
        bool bolTempR;
        #endregion

        #region "Métodos Propios"
        private void Mensaje(string texto)
        {
            MessageBox.Show(texto, "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information); // DialogResult
        }
        #endregion

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                fltTemperatura = Convert.ToSingle(txbTemperatura.Text);
                bolTempC = rdbTempC.Checked;
                bolTempF = rdbTempF.Checked;
                bolTempK = rdbTempK.Checked;
                bolTempR = rdbTempR.Checked;

                ClsConvTemp ConvTemp = new ClsConvTemp();

                if (bolTempC)
                {
                    ConvTemp.Gra_Conv = "C";
                    ConvTemp.Gra_C = fltTemperatura;
                }
                else if (bolTempF)
                {
                    ConvTemp.Gra_Conv = "F";
                    ConvTemp.Gra_F = fltTemperatura;
                }
                else if (bolTempK)
                {
                    ConvTemp.Gra_Conv = "K";
                    ConvTemp.Gra_K = fltTemperatura;
                }
                else if (bolTempR)
                {
                    ConvTemp.Gra_Conv = "R";
                    ConvTemp.Gra_R = fltTemperatura;
                }
                else
                {
                    Mensaje("Seleccione Temperatura");
                    ConvTemp = null;
                    return;
                }

                ConvTemp.Convertir();
                lblTempC.Text = "Cº = " + ConvTemp.Gra_C;
                lblTempF.Text = "Fº = " + ConvTemp.Gra_F;
                lblTempK.Text = "Kº = " + ConvTemp.Gra_K;
                lblTempR.Text = "Rº = " + ConvTemp.Gra_R;
            }

            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}
