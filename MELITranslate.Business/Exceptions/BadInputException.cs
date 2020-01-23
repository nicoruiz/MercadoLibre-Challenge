using System;
using System.Collections.Generic;
using System.Text;

namespace MELITranslate.Business.Exceptions
{
    public class BadInputException : Exception
    {
        public BadInputException(string message) : base(message) { }
    }
}
