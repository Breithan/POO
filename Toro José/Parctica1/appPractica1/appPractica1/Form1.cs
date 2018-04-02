using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDptoNomina;

namespace appPractica1
{
    public partial class frmLiquidacion : Form
    {
        public frmLiquidacion()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        string strNombre;
        float fltVrHora, fltKHW;
        #endregion

        #region "Métodos Propios"
        private void Mensaje (string texto)
        {
            MessageBox.Show(texto,"Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information); // DialogResult
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Clear(); // .Text = String.Empty;
            this.txtCantHtrab.Clear();
            this.txtVrHora.Clear();
            this.grbApagar.Visible = false;
            this.txtNombre.Focus();
            txtNombre.Enabled = true;
            txtCantHtrab.Enabled = true;
            txtVrHora.Enabled = true;
            btnLiquidar.Enabled = true;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar datos.
                strNombre = this.txtNombre.Text.Trim();
                fltKHW = Convert.ToSingle(this.txtCantHtrab.Text);
                fltVrHora = Convert.ToSingle(this.txtVrHora.Text);

                // Crear Instancia de clase.
                clsNomina myClass = new clsNomina();

                // Enviar Objeto.
                myClass.CantHW = fltKHW;
                myClass.VrHora = fltVrHora;

                // Invocar el método y tratamiento del error.
                if (! myClass.Liquidar())
                {
                    Mensaje(myClass.Error);
                    myClass = null;
                    return;
                }

                // Recuperar Información.
                this.lblSalBruto.Text = myClass.Sal_Bruto.ToString();
                this.lblCantHExt.Text = myClass.Cant_HExt.ToString();
                this.lblVrHExt.Text = myClass.Vr_Extras.ToString();
                this.lblVrRete.Text = myClass.Vr_Rete.ToString();
                this.lblAuxTte.Text = myClass.Vr_AuxTte.ToString();
                this.lblSalNeto.Text = myClass.Sal_Neto.ToString();

                txtNombre.Enabled = false;
                txtCantHtrab.Enabled = false;
                txtVrHora.Enabled = false;
                btnLiquidar.Enabled = false;
                grbApagar.Visible = true;
                myClass = null;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}
