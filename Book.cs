using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;

        }


        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public override string ToString()
        {
            return $" Title: {Title}, Author: {Author}, Publication year: {PublicationYear} ";
        }
    }
}
