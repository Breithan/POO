using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPractica2
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        #region Variables Globales
        int intDia;
        bool blnEsQuin, blnEsFest;
        #endregion

        #region Métodos Propios
        private void LlenarCombo()
        {
            this.cmbDiaPed.Items.Add("-- Seleccione un día --");
            this.cmbDiaPed.Items.Add("Lunes");
            this.cmbDiaPed.Items.Add("Martes");
            this.cmbDiaPed.Items.Add("Miercoles");
            this.cmbDiaPed.Items.Add("Jueves");
            this.cmbDiaPed.Items.Add("Viernes");
            this.cmbDiaPed.Items.Add("Sabado");
        }
        private void Mensaje(string texto)
        {
            MessageBox.Show(texto, "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information); // DialogResult
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            this.cmbDiaPed.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                intDia = this.cmbDiaPed.SelectedIndex;
                blnEsFest = this.chkEsFest.Checked;
                blnEsQuin = this.chkEsQuinc.Checked;
                //
                ClsOPEJamon objOPEJamon = new ClsOPEJamon();
                //
                objOPEJamon.DiaPed = intDia;
                objOPEJamon.EsFest = blnEsFest;
                objOPEJamon.EsQuinc = blnEsQuin;
                //
                if (!objOPEJamon.RealizarPedido())
                {
                    Mensaje(objOPEJamon.Error);
                    objOPEJamon = null;
                    return;
                }
                //
                this.txtCantNorm.Text = objOPEJamon.CantNorm.ToString();
                this.txtCantAdic.Text = objOPEJamon.CantAdic.ToString();
                this.txtCanTot.Text = objOPEJamon.CantTot.ToString();
                this.txtVrTot.Text = objOPEJamon.VrAPag.ToString();
                //
                this.grbApedir.Visible = true;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cmbDiaPed.Focus();
        }
    }
}
