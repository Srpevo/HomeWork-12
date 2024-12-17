using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Exceptions.InvalidPasswordException
{
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() { }

        public InvalidPasswordException(string message) : base(message) { }
    }
}
