using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var books = new List<Book>
        {
            new Book { Id = 1, Title = "Book A", Author = "Author 1", YearPublished = 2020, Genre = "Fiction" },
            new Book { Id = 2, Title = "Book B", Author = "Author 2", YearPublished = 2018, Genre = "Non-fiction" },
            new Book { Id = 3, Title = "Book C", Author = "Author 3", YearPublished = 2021, Genre = "Fiction" },
        };

        var users = new List<LibraryUser>
        {
            new LibraryUser { Id = 1, Name = "John", Email = "john@example.com", MembershipStartDate = new DateTime(2022, 1, 1) },
            new LibraryUser { Id = 2, Name = "Alice", Email = "alice@example.com", MembershipStartDate = new DateTime(2023, 5, 1) },
        };

            new Loan { BookId = 1, LoanDate = new DateTime(2023, 1, 15), ReturnDate = null, Book = books[0], },
            new Loan { BookId = 2, LoanDate = new DateTime(2023, 2, 1), ReturnDate = new DateTime(2023, 2, 10), Book = books[1] },
            new Loan { BookId = 3, LoanDate = new DateTime(2023, 3, 5), ReturnDate = null, Book = books[2] },
        };

        foreach (var user in users)
        {
            user.Loans.AddRange(loans.Where(l => l.BookId == 1 || l.BookId == 2 || l.BookId == 3).ToList());
        }

        var booksOnLoan = loans.Where(l => l.ReturnDate == null).Select(l => l.Book.Title);
        Console.WriteLine("Books on loan:");
        foreach (var title in booksOnLoan)
        {
            Console.WriteLine(title);
        }

        var lastBorrowedBooks = loans.OrderByDescending(l => l.LoanDate).Take(1).Select(l => l.Book.Title);
        Console.WriteLine("\nLast borrowed book:");
        foreach (var title in lastBorrowedBooks)
        {
            Console.WriteLine(title);
        }

        var genreCount = books.Where(b => b.Genre == "Fiction").Count();
        Console.WriteLine($"\nNumber of Fiction books: {genreCount}");

        var usersWithNoReturnedBooks = users.Where(u => u.Loans.All(l => l.ReturnDate == null)).Select(u => u.Name);
        Console.WriteLine("\nUsers with no returned books:");
        foreach (var name in usersWithNoReturnedBooks)
        {
            Console.WriteLine(name);
        }

        var mostBorrowedBook = loans.GroupBy(l => l.Book.Title)
                                    .OrderByDescending(g => g.Count())
                                    .FirstOrDefault()?.Key;
        Console.WriteLine($"\nMost borrowed book: {mostBorrowedBook}");

        var booksBorrowedIn2023 = loans.Where(l => l.LoanDate.Year == 2023).Select(l => l.Book.Title);
        Console.WriteLine("\nBooks borrowed in 2023:");
        foreach (var title in booksBorrowedIn2023)
        {
            Console.WriteLine(title);
        }

        var booksGroupedByGenre = books.GroupBy(b => b.Genre)
                                      .Select(g => new { Genre = g.Key, Count = g.Count() });
        Console.WriteLine("\nBooks grouped by genre:");
        foreach (var group in booksGroupedByGenre)
        {
            Console.WriteLine($"{group.Genre}: {group.Count}");
        }

        var uniqueUsersWhoBorrowed = loans.Select(l => l.BookId).Distinct().Count();
        Console.WriteLine($"\nNumber of unique users who borrowed books: {uniqueUsersWhoBorrowed}");

        var usersWithFirstMonthLoans = us
        var loans = new List<Loan>
        {ers.Where(u => u.MembershipStartDate.AddMonths(1) >= DateTime.Now)
                                            .Where(u => u.Loans.Any(l => l.LoanDate <= u.MembershipStartDate.AddMonths(1)))
                                            .Select(u => u.Email);
        Console.WriteLine("\nEmails of users who borrowed books in their first month:");
        foreach (var email in usersWithFirstMonthLoans)
        {
            Console.WriteLine(email);
        }

        var userWithMostLoans = users.OrderByDescending(u => u.Loans.Count).FirstOrDefault()?.Name;
        Console.WriteLine($"\nUser who borrowed the most books: {userWithMostLoans}");
    }
}