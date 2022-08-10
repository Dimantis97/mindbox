using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFigureLibrary
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    public class TTriangle : TFigure
    {
        private double ffFirstSide;
        private double ffSecondSide;
        private double ffThirdSide;

        #region Конструкторы
        /// <summary>
        /// Конструктор.
        /// </summary>
        public TTriangle()
        {
            fFirstSide = 0;
            fSecondSide = 0;
            fThirdSide = 0;
        }
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="_fFirstSide">Первая сторона треугольника.</param>
        /// <param name="_fSecondSide">Первая сторона треугольника.</param>
        /// <param name="_fThirdSide">Первая сторона треугольника.</param>
        public TTriangle(double _fFirstSide, double _fSecondSide, double _fThirdSide)
        {
            fFirstSide = _fFirstSide;
            fSecondSide = _fSecondSide;
            fThirdSide = _fThirdSide;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <returns>Полощадь треугольника по формуле Герона.</returns>
        public override double CalcSquare()
        {
            //блок проверки значений на корректность
            if (fFirstSide <= 0)
                throw new ArgumentOutOfRangeException("fFirstSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fFirstSide", fFirstSide }));
            if(fFirstSide > fSecondSide + fThirdSide || fFirstSide < fSecondSide - fThirdSide)
                throw new ArgumentOutOfRangeException("fFirstSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fFirstSide", fFirstSide }));
            if (fSecondSide <= 0)
                throw new ArgumentOutOfRangeException("fSecondSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fSecondSide", fSecondSide }));
            if (fSecondSide > fFirstSide + fThirdSide || fSecondSide < fFirstSide - fThirdSide)
                throw new ArgumentOutOfRangeException("fSecondSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fSecondSide", fSecondSide }));
            if (fThirdSide <= 0)
                throw new ArgumentOutOfRangeException("fThirdSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fThirdSide", fThirdSide }));
            if (fThirdSide > fFirstSide + fSecondSide || fThirdSide < fFirstSide - fSecondSide)
                throw new ArgumentOutOfRangeException("fThirdSide", string.Format(TConsts.S_ERR_SIDE_OUT_OF_RANGE_MSG, new object[] { "fThirdSide", fThirdSide }));
            //Полупериметр треугольника
            double P = (fFirstSide + fSecondSide + fThirdSide) / 2;

            return Math.Sqrt(P * (P - fFirstSide) * (P - fSecondSide) * (P - fThirdSide));
        }
        /// <summary>
        /// Проверка прямоугольника на прямоугольность.
        /// </summary>
        /// <returns>True - прямоугольный, False - непрямоугольный.</returns>
        public bool CheckRectangular()
        {
            // проверка на a^2 == b^2 + c^2
            if (Math.Pow(fFirstSide, 2) == Math.Pow(fSecondSide, 2) + Math.Pow(fThirdSide, 2) ||
                Math.Pow(fSecondSide, 2) == Math.Pow(fFirstSide, 2) + Math.Pow(fThirdSide, 2) ||
                Math.Pow(fThirdSide, 2) == Math.Pow(fFirstSide, 2) + Math.Pow(fSecondSide, 2))
                return true;
            return false;
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double fFirstSide
        {
            get { return ffFirstSide; }
            set { ffFirstSide = value; }
        }
        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double fSecondSide
        {
            get { return ffSecondSide; }
            set { ffSecondSide = value; }
        }
        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double fThirdSide
        {
            get { return ffThirdSide; }
            set { ffThirdSide = value; }
        }
        #endregion
    }
}
