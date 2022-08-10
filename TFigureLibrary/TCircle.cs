using TFigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFigureLibrary
{
    /// <summary>
    /// Класс круга.
    /// </summary>
    public class TCircle : TFigure
    {
        private double ffRadius; //радиус круга

        #region Конструкторы
        /// <summary>
        /// Конструктор.
        /// </summary>
        public TCircle()
        {
            fRadius = 0;
        }
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="_fRadius">Радиус круга.</param>
        public TCircle(double _fRadius)
        {
            fRadius = _fRadius;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Вычисление площади круга.
        /// </summary>
        /// <returns>Полощадь круга.</returns>
        public override double CalcSquare()
        {
            if (fRadius < 0)
                throw new ArgumentOutOfRangeException("fRadius", string.Format(TConsts.S_ERR_RADIUS_OUT_OF_RANGE_MSG, fRadius));
            return Math.PI * Math.Pow(fRadius, 2);
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double fRadius
        {
            get { return ffRadius; }
            set { ffRadius = value; }
        }
        #endregion
    }
}
