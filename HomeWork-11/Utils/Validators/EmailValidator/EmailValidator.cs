using HomeWork_12.Core.Exceptions.InvalidEmailException;
using System.Text.RegularExpressions;

namespace HomeWork_12.Utils.Validators.EmailValidator
{
    internal static class EmailValidator
    {

        public static bool CheckEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new InvalidEmailException("email cannot be empty");

            var Regx = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); // >;)

            if (!Regx.IsMatch(email))
            {
                string[] WordsToRemove = { "gmail", "com", "mail", "@", "." };
                string CorrectEmail = email;

                foreach (string word in WordsToRemove)
                {
                    CorrectEmail = CorrectEmail.Replace(word, "");
                }
                throw new InvalidEmailException($"incorrect email, correct > {CorrectEmail}@gmail.com");
            }

            return true;
        }
    }
}