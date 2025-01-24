using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorteht
{
    internal class Book
    {
        private const int MaxLength = 13;
        private const string Prefix = "978";
        public string? name;
        public string? author;
        public string? publisher;
        private double _price;
        public string isbn;
        public static string? theme;


        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.isbn = isbn;

        }

        internal void ChangeTheme(string newTheme)
        {
            theme = newTheme;
        }

        internal void GetBookDetails(string isbn)
        {
            if (this.isbn == isbn)
            {
                Console.WriteLine("Book details: ");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Publisher: " + publisher);
                Console.WriteLine("Price: " + _price);
                Console.WriteLine("ISBN: " + isbn);
                Console.WriteLine("Theme: " + theme);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }
        }

    }
}
