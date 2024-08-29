namespace Practice3.Exceptions
{
    public class BookAlreadyCheckedOutException : Exception
    {
        public BookAlreadyCheckedOutException() : base() { }

        public BookAlreadyCheckedOutException(string message) : base(message) { }

        public BookAlreadyCheckedOutException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
