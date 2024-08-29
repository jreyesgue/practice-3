namespace Practice3.Exceptions
{
    public class BookNotCheckedOutException : Exception
    {
        public BookNotCheckedOutException() { }

        public BookNotCheckedOutException(string message) : base(message) { }

        public BookNotCheckedOutException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
