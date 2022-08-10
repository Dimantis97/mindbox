using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFigureLibrary;

namespace UnitTestApp
{
    [TestClass]
    public class TTestClass
    {
        /// <summary>
        /// Тест вычисления площади круга.
        /// </summary>
        [TestMethod]
        public void TestCircleSquareCalc()
        {
            Assert.AreEqual(Math.PI * 9, new TCircle(3).CalcSquare());
        }
        /// <summary>
        /// Тест вычисления площади круга при отрицательном значении радиуса круга.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCircleNegativeRadius()
        {
            double fSquare = new TCircle(-3).CalcSquare();
        }
        /// <summary>
        /// Тестирование вычисления площади треугольника.
        /// </summary>
        [TestMethod]
        public void TestTriangleSquareCalc()
        {
            Assert.AreEqual((double)6.0, new TTriangle(3,4,5).CalcSquare());
        }
        /// <summary>
        /// Тестирование вычисления площади треугольника с недопустимым значением одной из сторон.
        /// </summary>
        [TestMethod]
        public void TestTriangleInvalidSides()
        {
            double[][] arValues = new double[][] { new double[] { -3, 4, 5 },
                                                   new double[] { 3, -4, 5},
                                                   new double[] { 3, 4, -5},
                                                   new double[] { 20, 4, 5}};
            foreach(double[] arCurrValues in arValues)
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TTriangle(arCurrValues[0], arCurrValues[1], arCurrValues[2]).CalcSquare());
        }
        /// <summary>
        /// Тестирование проверки треугольника на прямоугольность.
        /// </summary>
        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            Assert.AreEqual(true, new TTriangle(3, 4, 5).CheckRectangular());
        }
    }
}
