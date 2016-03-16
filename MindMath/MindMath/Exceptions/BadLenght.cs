using System;

namespace MindMath.Exceptions
{
    public class BadLenght : Exception
    {
        private readonly string _message;
        public BadLenght()
        {
            _message = "Сумма квадратов катетов не равна квадрату гипотенузы";
        }

        public override string Message
        {
            get { return _message; }
        }
    }
}