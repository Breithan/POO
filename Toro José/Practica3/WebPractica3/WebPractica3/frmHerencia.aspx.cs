using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Librerías personalizadas.
using LibFiguras;

namespace WebPractica3
{
    public partial class frmHerencia : System.Web.UI.Page
    {

        #region => MemoryV
        static string strFig;
        #endregion
        #region => Methods
        /// <summary>
        /// Establece un mensaje error, al encontrarlo.
        /// </summary>
        /// <param name="texto">Mensaje.</param>
        private void Mensaje(string texto)
        {
            this.lblMsj.Text = texto.Trim();
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                strFig = this.rblFiguras.SelectedValue;
            }
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFig = this.rblFiguras.SelectedValue;


            this.pnlTrapecio.Visible = false;
            this.pnlElipse.Visible = false;
            this.pnlTriangulo.Visible = false;
            this.lblMsj.Text = string.Empty;
            this.pnlRpta.Visible = false;

            switch (strFig)
            {
                case "opcTrap":
                    this.txtBaseMy.Text = string.Empty;
                    this.txtBaseMn.Text = string.Empty;
                    this.txtLado1.Text = string.Empty;
                    this.txtLado2.Text = string.Empty;
                    this.txtAltura.Text = string.Empty;

                    this.pnlTrapecio.Visible = true;

                    this.txtBaseMy.Focus();
                    break;
                case "opcElip":
                    this.txtRadMy.Text = string.Empty;
                    this.txtRadMn.Text = string.Empty;

                    this.pnlElipse.Visible = true;

                    this.txtRadMy.Focus();
                    break;

                default:
                    this.txtLadoA.Text = string.Empty;
                    this.txtLadoB.Text = string.Empty;
                    this.txtAngulo.Text = string.Empty;

                    this.pnlTriangulo.Visible = true;

                    this.txtRadMy.Focus();
                    break;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lblArea.Text = string.Empty;
            this.lblPerim.Text = string.Empty;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            // Vl son los diferentes valores de las figuras.
            float fltValue1 = 0, fltValue2 = 0, fltValue3 = 0, fltValue4 = 0, fltValue5 = 0;
            float fltAreaFg = 0, fltPerime = 0;

            try
            {
                Mensaje(string.Empty);
                switch (strFig)
                {
                    case "opcTrap":
                        fltValue1 = Convert.ToSingle(this.txtBaseMy.Text);
                        fltValue2 = Convert.ToSingle(this.txtBaseMn.Text);
                        fltValue3 = Convert.ToSingle(this.txtLado1.Text);
                        fltValue4 = Convert.ToSingle(this.txtLado2.Text);
                        fltValue5 = Convert.ToSingle(this.txtAltura.Text);
                        ClsTrapecio objTrapec = new ClsTrapecio();
                        objTrapec.BaseMay = fltValue1;
                        objTrapec.BaseMen = fltValue2;
                        objTrapec.LadoUno = fltValue3;
                        objTrapec.LadoDos = fltValue4;
                        objTrapec.AlturaT = fltValue5;
                        if (!objTrapec.HallarArea() || !objTrapec.HallarPeri())
                        {
                            Mensaje(objTrapec.Error);
                            objTrapec = null;
                            return;
                        }
                        fltAreaFg = objTrapec.Area;
                        fltPerime = objTrapec.Peri;
                        objTrapec = null;
                        break;

                    case "opcElip":
                        fltValue1 = Convert.ToSingle(this.txtRadMy.Text);
                        fltValue2 = Convert.ToSingle(this.txtRadMn.Text);
                        ClsElipse objElipse = new ClsElipse(fltValue1, fltValue2);
                        if (!objElipse.HallarArea() || !objElipse.HallarPeri())
                        {
                            Mensaje(objElipse.Error);
                            objElipse = null;
                            return;
                        }
                        fltAreaFg = objElipse.Area;
                        fltPerime = objElipse.Peri;
                        objElipse = null;
                        break;

                    default:
                        fltValue1 = Convert.ToSingle(this.txtLadoA.Text);
                        fltValue2 = Convert.ToSingle(this.txtLadoB.Text);
                        fltValue3 = Convert.ToSingle(this.txtAngulo.Text);
                        ClsTriangulo objTriang = new ClsTriangulo(fltValue1, fltValue2, fltValue3);
                        if (!objTriang.HallarArea() || !objTriang.HallarPeri())
                        {
                            Mensaje(objTriang.Error);
                            objTriang = null;
                            return;
                        }
                        fltAreaFg = objTriang.Area;
                        fltPerime = objTriang.Peri;
                        objTriang = null;
                        break;
                }
                this.lblArea.Text  = fltAreaFg.ToString();
                this.lblPerim.Text = fltPerime.ToString();
                this.pnlRpta.Visible = true;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}