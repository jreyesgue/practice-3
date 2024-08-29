using Practice3.LibrarySystem;
using Practice3.Utils;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            bool finish = false;

            do
            {
                MenuPlayer.DisplayMenu();

                switch (ConsoleReader.GetOption())
                {
                    case 1:
                        string bookIsbn = ConsoleReader.GetStringParam("\nEnter the Book ISBN: ");
                        string bookTitle = ConsoleReader.GetStringParam("Enter the Book Title: ");
                        string bookAuthor = ConsoleReader.GetStringParam("Enter the Book Author: ");

                        library.AddBook(new Book(bookIsbn, bookTitle, bookAuthor));
                        break;
                    case 2:
                        string removeIsbn = ConsoleReader.GetStringParam("\nEnter the Book ISBN: ");

                        library.RemoveBook(removeIsbn);
                        break;
                    case 3:
                        string checkOutIsbn = ConsoleReader.GetStringParam("\nEnter the Book ISBN: ");

                        library.CheckOutBook(checkOutIsbn);
                        break;
                    case 4:
                        string returnIsbn = ConsoleReader.GetStringParam("\nEnter the Book ISBN: ");

                        library.ReturnBook(returnIsbn);
                        break;
                    case 5:
                        library.ListAllBooks();
                        break;
                    case 6:
                        Console.WriteLine("\nGoodbye :)");
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Try Again.\n");
                        break;
                }
            } while (!finish);
        }
    }
}
