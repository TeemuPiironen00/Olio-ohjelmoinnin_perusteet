using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookExcercise
{
    internal class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;


        public void SetId(string idValue)
        {
            this.id = idValue;
            if (idValue.Length > 5)
            {
                Console.WriteLine(this.title + " id virheellinen");

            }
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            SetId(id);
            this.price = price;
        }

        internal void BookPrint()
        {
            Console.WriteLine($"title: {this.title}, author: {this.author}, id: {this.id}, price: {this.price}");
        }

        public void CompareBook(Book book2)
        {
            if (this.price < book2.price)
            {
                Console.WriteLine("Book1 is cheaper");
            }
            else if (this.price > book2.price)
            {
                Console.WriteLine("Book2 is cheaper");
            }
            else
            {
                Console.WriteLine("Books are the same price");
            }
        }
    }
}
