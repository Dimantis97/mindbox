using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFigureLibrary
{
    /// <summary>
    /// Класс констант.
    /// </summary>
    public static class TConsts
    {
        #region Строки
        /// <summary>
        /// Сообщение: недопустимое значение радиуса круга.
        /// </summary>
        public const string S_ERR_RADIUS_OUT_OF_RANGE_MSG = "Радиус круга: {0}. Недопустим отрицательный радиус.";
        /// <summary>
        /// Сообщение: значение стороны треугольнка должно быть больше или равно 0.
        /// </summary>
        public const string S_ERR_SIDE_OUT_OF_RANGE_MSG = "Сторона треугольника {0}: {1}. Значение стороны треугольнка должно быть больше или равно 0.";
        /// <summary>
        /// Сообщение: значение стороны треугольнка должно соответстовать пропорции.
        /// </summary>
        public const string S_ERR_SIDE_OUT_OF_PROP_MSG = "Сторона треугольника {0}: {1}. Значение стороны должно соответстовать пропорциям: a < b + c и a > b - c.";
        #endregion
    }
}
