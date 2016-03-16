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
        public static double RightAngleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ZeroLenght();

            if (_powSumm(a, b, c) || _powSumm(b, c, a) || _powSumm(c, b, a))
                throw new BadLenght();

            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private static bool _powSumm(double a, double b, double c)
        {
            return Math.Abs(Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2))) < 0.00001;
        }
    }
}
