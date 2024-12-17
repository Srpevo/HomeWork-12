using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Exceptions.InvalidEmailException
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException() { }

        public InvalidEmailException(string message) : base(message) { }
    }
}
