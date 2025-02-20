using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FileExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileExample();
            WriteJsonFile();
            ReadJsonFile();
        }

        static void WriteJsonFile()
        {
            const string PATH = @"C:\Users\toxii\Desktop\Ohjelmointi\Olio-ohjelmointi perusteet\Olio-ohjelmoinnin_perusteet\FileExercise\testi.json";
            List<Book> books = new List<Book>
                {
                    new Book { Title = "Maa", Author = "Juhani Aho", price = 91 },
                    new Book { Title = "Seitsemän veljestä", Author = "Aleksis Kivi", price = 18 },
                    new Book { Title = "Tuntematon sotilas", Author = "Väinö Linna", price = 19 },
                    new Book { Title = "Sinuhe egyptiläinen", Author = "Mika Waltari", price = 19 },
                    new Book { Title = "Punainen viiva", Author = "Ilmari Kianto", price = 12 }
                };


            File.WriteAllText(PATH, JsonConvert.SerializeObject(books));
        }

        static void ReadJsonFile()
        {
            const string PATH = @"C:\Users\toxii\Desktop\Ohjelmointi\Olio-ohjelmointi perusteet\Olio-ohjelmoinnin_perusteet\FileExercise\testi.json";
            string json = File.ReadAllText(PATH, System.Text.Encoding.UTF8);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);

            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.price}");
            }

        }

            static void FileExample()
        {
            string filePath = @"C:\Users\toxii\Desktop\Ohjelmointi\Olio-ohjelmointi perusteet\Olio-ohjelmoinnin_perusteet\FileExercise\testi.txt";

            try
            {
                FileManager fm = new FileManager(filePath);
                Console.WriteLine(fm.ReadWords());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int price { get; set; }
        }
    }
}
