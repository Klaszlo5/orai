using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public bool IsAvailable { get; private set; }

        // Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true; 
        }

        public void Borrow()
        {
            if (!IsAvailable)
            {
                throw new InvalidOperationException("The book is currently not available.");
            }
            IsAvailable = false;
        }

        public void Return()
        {
            if (IsAvailable)
            {
                throw new InvalidOperationException("The book is already available.");
            }
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN}) - " + (IsAvailable ? "Available" : "Borrowed");
        }
    }

    public class Borrower
    {
        public string Name { get; }
        public string Email { get; }
        private List<Book> borrowedBooks;

        // Constructor
        public Borrower(string name, string email)
        {
            Name = name;
            Email = email;
            borrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsAvailable)
            {
                throw new InvalidOperationException("This book is currently unavailable.");
            }

            borrowedBooks.Add(book);
            book.Borrow();
        }

        public void ReturnBook(Book book)
        {
            if (!borrowedBooks.Contains(book))
            {
                throw new InvalidOperationException("This book was not borrowed by you.");
            }

            borrowedBooks.Remove(book);
            book.Return();
        }

        public void DisplayBorrowedBooks()
        {
            if (borrowedBooks.Count == 0)
            {
                Console.WriteLine($"{Name} has no borrowed books.");
            }
            else
            {
                Console.WriteLine($"{Name}'s borrowed books:");
                foreach (var book in borrowedBooks)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }
    }

    public class Library
    {
        private List<Book> books;
        private List<Borrower> borrowers;

        // Constructor
        public Library()
        {
            books = new List<Book>();
            borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddBorrower(Borrower borrower)
        {
            borrowers.Add(borrower);
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("All books in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void DisplayAllBorrowers()
        {
            if (borrowers.Count == 0)
            {
                Console.WriteLine("No borrowers in the library.");
            }
            else
            {
                Console.WriteLine("All borrowers:");
                foreach (var borrower in borrowers)
                {
                    Console.WriteLine($"{borrower.Name} ({borrower.Email})");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Library library = new Library();

                Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
                Book book2 = new Book("1984", "George Orwell", "9780451524935");
                Book book3 = new Book("Moby-Dick", "Herman Melville", "9781851244422");

                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);

                Borrower borrower1 = new Borrower("John Doe", "johndoe@example.com");
                Borrower borrower2 = new Borrower("Jane Smith", "janesmith@example.com");

                library.AddBorrower(borrower1);
                library.AddBorrower(borrower2);

                library.DisplayAllBooks();
                library.DisplayAllBorrowers();

                borrower1.BorrowBook(book1);
                borrower2.BorrowBook(book2);

                borrower1.DisplayBorrowedBooks();
                borrower2.DisplayBorrowedBooks();

                try
                {
                    borrower1.BorrowBook(book2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                borrower1.ReturnBook(book1);
                Console.WriteLine("\nAfter returning 'The Great Gatsby':");
                borrower1.DisplayBorrowedBooks();
                library.DisplayAllBooks();

                library.DisplayAllBooks();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}