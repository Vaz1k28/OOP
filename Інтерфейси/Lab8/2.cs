using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    interface IPrintable
    {
        void Print();
    }

    interface IBorrowable
    {
        void BorrowItem();
        void ReturnItem();
        bool IsAvailable();
    }

    class Book : IPrintable, IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        private bool isBorrowed;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            isBorrowed = false;
        }

        public void Print()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Available: {(!isBorrowed ? "Yes" : "No")}");
        }

        public void BorrowItem()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine($"Book '{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is already borrowed.");
            }
        }

        public void ReturnItem()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine($"Book '{Title}' has been returned.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' is not currently borrowed.");
            }
        }

        public bool IsAvailable()
        {
            return !isBorrowed;
        }
    }

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);

            Console.WriteLine("Book 1 Information:");
            book1.Print();
            Console.WriteLine("\nBook 2 Information:");
            book2.Print();

            Console.WriteLine("\nBorrowing Book 1:");
            book1.BorrowItem();

            Console.WriteLine("\nAttempting to Borrow Book 1 Again:");
            book1.BorrowItem();

            Console.WriteLine("\nReturning Book 1:");
            book1.ReturnItem();

            Console.WriteLine("\nAvailability of Book 1: " + (book1.IsAvailable() ? "Yes" : "No"));
        }
    }
}
   