using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book("1984","George Orwell", 1949);
            Book book1 = new Book("The Law", "Frédéric Bastiat", 1848);
            
            library.AddBook(book);
            library.AddBook(book1);

            library.BookList();
            
            library.RemoveBook(book);

            library.BookList();

            Console.Read();
        }
    }
}
