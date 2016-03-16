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
        public void AreaTest()
        {

            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, 2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, -2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(-1, -2, -3));

            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, -2, 3));
            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, -2, -3));

            Assert.Throws<ZeroLenght>(() => Triangle.RightAngleArea(1, 2, -3));

        }
    }
}
