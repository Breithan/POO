using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFiguraGeometrica
{
    public abstract class ClsFiguraGeometrica
    {
        #region //Stock Memory//
        // Memoria Privada.
        protected float fltArea;
        protected float fltPeri;
        protected string strError;
        // Memoria Pública.
        /// <summary>
        /// Devuelve el valor del área de la figura.
        /// </summary>
        public float Area { get { return fltArea; } }
        /// <summary>
        /// Devuelve el valor del perímetro de la figura.
        /// </summary>
        public float Peri { get { return fltPeri; } }
        /// <summary>
        /// Devuelve el error de cálculo de la figura.
        /// </summary>
        public string Error { get { return strError; } }
        #endregion
        #region //Methods//
        public abstract bool HallarArea();
        public abstract bool HallarPeri();
        #endregion
    }
}
