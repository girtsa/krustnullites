
using System;


namespace NoslDar
{
    public class NumberLargerThanNineException : Exception
    {
        public NumberLargerThanNineException()
        {

        }

        public NumberLargerThanNineException(string message) : base(message)
        {

        }

        public NumberLargerThanNineException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}