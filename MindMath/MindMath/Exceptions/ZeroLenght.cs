using System;

namespace MindMath.Exceptions
{
    public class ZeroLenght : Exception
    {
        private readonly string _message;
        public ZeroLenght()
        {
            _message = "длина одной из сторон треугольника <=0";
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}