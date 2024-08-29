using Practice3.Exceptions;

namespace Practice3.LibrarySystem
{
    public class Book
    {
        private bool isCheckedOut;
        public string ISBN { get; init; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author,
            bool isCheckedOut = false)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            this.isCheckedOut = isCheckedOut;
        }

        public void CheckOut()
        {
            if (isCheckedOut)
            {
                throw new BookAlreadyCheckedOutException($"The Book {ISBN} is already checked out.");
            }

            isCheckedOut = true;
        }

        public void Return()
        {
            if (!isCheckedOut)
            {
                throw new BookNotCheckedOutException($"The Book {ISBN} is not checked out.");
            }

            isCheckedOut = false;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\n--- Book {ISBN} ---");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Status: {(isCheckedOut ? "Checked Out" : "In Stock")}");
        }
    }
}
