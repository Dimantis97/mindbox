using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFigureLibrary
{
    /// <summary>
    /// Абстрактный класс геометрической фигуры.
    /// </summary>
    public abstract class TFigure
    {
        /// <summary>
        /// Вычислени площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double CalcSquare();

    }
}
