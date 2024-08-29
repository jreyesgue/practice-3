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
            isCheckedOut = true;
        }

        public void Return()
        {
            isCheckedOut = false;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\n--- Book {ISBN} ---");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Is {(isCheckedOut ? "" : "Not")} Checked Out");
        }
    }
}
