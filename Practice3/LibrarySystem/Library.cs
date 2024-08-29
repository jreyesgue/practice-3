using Practice3.Exceptions;

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
            try
            {
                Book book = FindBookByISBN(bookIsbn);
                _books.Remove(book);
                Console.WriteLine("All done!");
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void CheckOutBook(string bookIsbn)
        {
            try
            {
                Book book = FindBookByISBN(bookIsbn);
                book.CheckOut();
                Console.WriteLine("All done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ReturnBook(string bookIsbn)
        {
            try
            {
                Book book = FindBookByISBN(bookIsbn);
                book.Return();
                Console.WriteLine("All done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ListAllBooks()
        {
            _books.ForEach(book => book.DisplayDetails());
        }

        private Book FindBookByISBN(string bookIsbn)
        {
            Book? result = _books.Find(book => book.ISBN == bookIsbn);

            return result is not null
                ? result
                : throw new BookNotFoundException($"The Book {bookIsbn} could not be found.");
        }
    }
}
