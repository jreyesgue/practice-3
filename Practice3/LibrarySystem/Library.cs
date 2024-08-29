namespace Practice3.LibrarySystem
{
    public class Library
    {
        private readonly List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(string bookIsbn)
        {
            _books.RemoveAll(book => book.ISBN == bookIsbn);
        }

        public void CheckOutBook(string bookIsbn)
        {
            Book book = FindBookByISBN(bookIsbn);
            book.CheckOut();
        }

        public void ReturnBook(string bookIsbn)
        {
            Book book = FindBookByISBN(bookIsbn);
            book.Return();
        }

        public void ListAllBooks()
        {
            _books.ForEach(book => book.DisplayDetails());
        }

        private Book FindBookByISBN(string bookIsbn)
        {
            return _books.Find(book => book.ISBN == bookIsbn);
        }
    }
}
