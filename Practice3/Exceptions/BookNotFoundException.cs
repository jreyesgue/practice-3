namespace Practice3.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException() : base() { }

        public BookNotFoundException(string message) : base(message) { }

        public BookNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
