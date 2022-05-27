namespace ConsoleDivisionExceptionApp
{
    [Serializable]
    public class MyClassException : Exception
    {
        public MyClassException()
        {

        }

        public MyClassException(string? message) : base(message)
        {

        }

        public MyClassException(string? message, Exception? innerException) : base(message, innerException)
        {

        }

        public string? MyProperty { get; set; }
    }
}