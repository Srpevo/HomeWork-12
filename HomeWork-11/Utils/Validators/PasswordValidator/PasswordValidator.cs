using HomeWork_12.Core.Exceptions.InvalidPasswordException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Utils.Validators.PasswordValidator
{
    internal static class PasswordValidator
    {
        public static bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new InvalidPasswordException("");
            else if (password.Length < 8)
                throw new InvalidPasswordException("");
            else
            return true;
        }
    }
}
