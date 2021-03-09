using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Utilities.Exceptions
{
    public class TLUException : Exception
    {
        public TLUException()
        {

        }
        public TLUException(string message):base(message)
        {

        }
        public TLUException(string message, Exception inner): base(message,inner)
        {

        }
    }
}
