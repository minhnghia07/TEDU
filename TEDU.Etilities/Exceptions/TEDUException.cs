using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TEDU.Utilities.Exceptions
{
    public class TEDUException : Exception
    {
        public TEDUException()
        {
        }

        public TEDUException(string message) : base(message)
        {
        }

        public TEDUException(string message, Exception innerException) : base(message, innerException)
        {
        }

       
    }
}
