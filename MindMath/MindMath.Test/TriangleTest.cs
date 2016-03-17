using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindMath.Exceptions;
using Xunit;

namespace MindMath.Test
{
    public class TriangleTest
    {
        [Fact]
        public void RightAngleAreaTest()
        {
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, 2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, -2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, -2, -3));

            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, -2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, -2, -3));

            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, 2, -3));

            Assert.Throws<BadLenght>(() => Triangle.RightAngleArea(1, 2, 3));
            Assert.Throws<BadLenght>(() => Triangle.RightAngleArea(2, 1, 3));
            Assert.Throws<BadLenght>(() => Triangle.RightAngleArea(3, 2, 1));
            Assert.Throws<BadLenght>(() => Triangle.RightAngleArea(34, 12, 1231));
            Assert.Throws<BadLenght>(() => Triangle.RightAngleArea(564, 232, 112));

            Assert.Equal(Triangle.RightAngleArea(3, 4, 5),6);
            Assert.Equal(Triangle.RightAngleArea(8, 23, Math.Sqrt(8*8+23*23)), 92);

        }
    }
}
