using HomeWork_12.Core.Exceptions.InvalidNameException;

namespace HomeWork_12.Utils.Validators.NameValidator
{
    internal static class NameValidator
    {
        public static bool CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new InvalidNameException("name cannot be empty");

            else if (name.Any(char.IsDigit))
                throw new InvalidNameException("name cannot contain numbers");

            else if (name.Length < 3)
                throw new InvalidNameException("the name cannot be less than three symbols");

            else return true;
        }
    }
}