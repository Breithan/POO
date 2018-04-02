using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFiguras
{
    using LibFiguraGeometrica;

    public class ClsTrapecio : ClsFiguraGeometrica
    {
        #region => Stock Memory.
        /// <summary>
        /// Establece la base mayor del Trapecio.
        /// </summary>
        public float BaseMay { private get; set; }
        /// <summary>
        /// Establece la base menor del Trapecio.
        /// </summary>
        public float BaseMen { private get; set; }
        /// <summary>
        /// Establece el lado izquierdo del Trapecio.
        /// </summary>
        public float LadoUno { private get; set; }
        /// <summary>
        /// Establece el lado derecho del Trapecio.
        /// </summary>
        public float LadoDos { private get; set; }
        /// <summary>
        /// Establece la altura del Trapecio.
        /// </summary>
        public float AlturaT { private get; set; }
        #endregion
        #region => Constructor.
        /// <summary>
        /// Constructor del Trapecio sin parámetros.
        /// </summary>
        public ClsTrapecio()
        {
            fltArea = 0;
            fltPeri = 0;
            BaseMay = 0;
            BaseMen = 0;
            LadoUno = 0;
            LadoDos = 0;
            AlturaT = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Constructor del Trapecio parametrizado.
        /// </summary>
        /// <param name="baseMay">Valor de la Base Mayor del Trapecio.</param>
        /// <param name="baseMen">Valor de la Base Menor del Trapecio.</param>
        /// <param name="ladoUno">Valor del Lado Izquierdo del Trapecio.</param>
        /// <param name="ladoDos">Valor del Lado Derecho del Trapecio.</param>
        /// <param name="alturaT">Valor de la Altura del Trapecio.</param>
        public ClsTrapecio(float baseMay, float baseMen, float ladoUno, float ladoDos, float alturaT)
        {
            fltArea = 0;
            fltPeri = 0;
            BaseMay = baseMay;
            BaseMen = baseMen;
            LadoUno = ladoUno;
            LadoDos = ladoDos;
            AlturaT = alturaT;
            strError = string.Empty;
        }
        #endregion
        #region => Methods.
        // Métodos Privados.
        private bool Validar()
        {
            // Valida la base mayor de. trapecio.
            if (BaseMay <= 0)
            {
                strError = "Valor de la Base Mayor no es válido";
                return false;
            }
            // Valida la base menor del trapecio.
            if (BaseMen <= 0)
            {
                strError = "Valor de la Base Menor no es válido";
                return false;
            }
            // Valida el lado izquierdo del trapecio.
            if (LadoUno <= 0)
            {
                strError = "Valor del Lado Izquierdo no es válido";
                return false;
            }
            // Valida el lado derecho del trapecio.
            if (LadoDos <= 0)
            {
                strError = "Valor del Lado Derecho no es válido";
                return false;
            }
            // Valida la altura del trapecio.
            if (AlturaT <= 0)
            {
                strError = "Valor de la Altura no es válido";
                return false;
            }

            return true;
        }
        // Métodos Públicos.
        /// <summary>
        /// Cálcula el área del Trapecio.
        /// </summary>
        public override bool HallarArea()
        {
            try
            {
                if (!Validar()) return false;
                fltArea = AlturaT * ((BaseMay + BaseMen) / 2);
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Cálcula el perímetro del Trapecio.
        /// </summary>
        public override bool HallarPeri()
        {
            try
            {
                if (!Validar()) return false;
                fltPeri = BaseMay + BaseMen + LadoUno + LadoDos;
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

    public class ClsElipse : ClsFiguraGeometrica
    {
        #region => Stock Memory.
        /// <summary>
        /// Establece el radio mayor de la elipse.
        /// </summary>
        public float RadioMay { private get; set; }
        /// <summary>
        /// Establece el radio menor de la elipse.
        /// </summary>
        public float RadioMen { private get; set; }
        #endregion
        #region => Constructor.
        /// <summary>
        /// Constructor de la elipse sin parámetros.
        /// </summary>
        public ClsElipse()
        {
            fltArea = 0;
            fltPeri = 0;
            RadioMay = 0;
            RadioMen = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Constructor de la elipse con parámetros.
        /// </summary>
        /// <param name="radioMay">Valor del Radio Mayor.</param>
        /// <param name="radioMen">Valor del Radio Menor.</param>
        public ClsElipse(float radioMay, float radioMen)
        {
            fltArea = 0;
            fltPeri = 0;
            RadioMay = radioMay;
            RadioMen = radioMen;
            strError = string.Empty;
        }
        #endregion
        #region => Methods.
        // Métodos Privados.
        private bool Validar()
        {
            // Valida el radio mayor de la elipse.
            if (RadioMay <= 0)
            {
                strError = "Valor de la Base Mayor no es válido";
                return false;
            }
            // Valida el radio menor de la elipse.
            if (RadioMen <= 0)
            {
                strError = "Valor de la Base Menor no es válido";
                return false;
            }
            return true;
        }
        // Métodos Públicos.
        /// <summary>
        /// Cálcula el perímetro de la elipse.
        /// </summary>
        public override bool HallarArea()
        {
            try
            {
                if (!Validar()) return false;
                fltArea = RadioMay * RadioMen * Convert.ToSingle(Math.PI);
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Cálcula el perímetro de la elipse.
        /// </summary>
        public override bool HallarPeri()
        {
            try
            {
                if (!Validar()) return false;
                var varRaiz = Convert.ToSingle(Math.Sqrt(((3 * RadioMay) + RadioMen) * (RadioMay + (3 * RadioMen))));
                fltPeri = Convert.ToSingle(Math.PI) * ((3 * (RadioMay + RadioMen)) - varRaiz);
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

    public class ClsTriangulo : ClsFiguraGeometrica
    {
        #region => Stock Memory.
        /// <summary>
        /// Establece el lado derecho del triángulo.
        /// </summary>
        public float LadoUno { private get; set; }
        /// <summary>
        /// Establece el lado izquierdo del triángulo.
        /// </summary>
        public float LadoDos { private get; set; }
        /// <summary>
        /// Establece el ángulo del triángulo.
        /// </summary>
        public float AnguloT { private get; set; }
        #endregion
        #region => Constructor.
        /// <summary>
        /// Constructor del Triángulo sin parámetros.
        /// </summary>
        public ClsTriangulo()
        {
            fltArea = 0;
            fltPeri = 0;
            LadoUno = 0;
            LadoDos = 0;
            AnguloT = 0;
            strError = string.Empty;
        }
        /// <summary>
        /// Constructor del Triángulo parametrizado.
        /// </summary>
        /// <param name="ladoUno">Valor del primer lado del triángulo.</param>
        /// <param name="ladoDos">Valor del segundo lado del triángulo.</param>
        /// <param name="anguloT">Valor del Ángulo.</param>
        public ClsTriangulo(float ladoUno, float ladoDos, float anguloT)
        {
            fltArea = 0;
            fltPeri = 0;
            LadoUno = ladoUno;
            LadoDos = ladoDos;
            AnguloT = anguloT;
            strError = string.Empty;
        }
        #endregion
        #region => Methods.
        // Métodos Privados.
        private bool Validar()
        {
            // Valida uno de los lados del triángulo.
            if (LadoUno <= 0)
            {
                strError = "Valor del Lado Izquierdo no es válido";
                return false;
            }
            // Valida la base del triángulo.
            if (LadoDos <= 0)
            {
                strError = "Valor del Lado Derecho no es válido";
                return false;
            }
            // Valida el ángulo del triángulo.
            if (AnguloT <= 0)
            {
                strError = "Valor de la Altura no es válido";
                return false;
            }
            return true;
        }
        /// <summary>
        /// Cálcula el área del Triángulo.
        /// </summary>
        public override bool HallarArea()
        {
            try
            {
                if (!Validar()) return false;
                AnguloT = Convert.ToSingle(Math.PI * AnguloT / 180.0);
                fltArea = (LadoUno * LadoDos) / 2 * Convert.ToSingle(Math.Sin(AnguloT));
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        /// <summary>
        /// Cálcula el perímetro del triángulo.
        /// </summary>
        public override bool HallarPeri()
        {
            try
            {
                if (!Validar()) return false;
                var varLadoTres = Math.Sqrt(Math.Pow(LadoUno, 2) + Math.Pow(LadoDos, 2));
                fltPeri = LadoUno + LadoDos + Convert.ToSingle(varLadoTres);
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