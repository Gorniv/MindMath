using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindMath.Exceptions;

namespace MindMath
{
    public class Triangle
    {
        /// <summary>
        /// Вычисление площади прямоугольного треугольника
        /// </summary>
        /// <param name="a">Длина одной из сторон</param>
        /// <param name="b">Длина одной из сторон</param>
        /// <param name="c">Длина одной из сторон</param>
        /// <returns>Площадь</returns>
        public static double RightAngleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ZeroLenght();

            if (!_rightAngleTriangle(a, b, c) && !_rightAngleTriangle(b, c, a) && !_rightAngleTriangle(c, b, a))
                throw new BadLenght();

            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private static bool _rightAngleTriangle(double a, double b, double c)
        {
            return Math.Abs(Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2))) < 0.00001;
        }
    }
}
