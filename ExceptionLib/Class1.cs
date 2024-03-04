using System;

namespace ExceptionLib
{
    public class DivideByZeroMyException : Exception
    {
        public DivideByZeroMyException(string message) : base(message) { }
    }
    public class OutOfRangMyException : Exception
    {
        public OutOfRangMyException(string message) : base(message) { }
    }
}
