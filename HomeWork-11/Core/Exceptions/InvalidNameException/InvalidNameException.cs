namespace HomeWork_12.Core.Exceptions.InvalidNameException
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException() { }

        public InvalidNameException(string message) : base(message) { } 
    }
}
