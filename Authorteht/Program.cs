namespace Authorteht
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        Book book1 = new Book("Kaisan matkat", "Liisa.M", "KoiraKirjat", 20.0, "978-4-36-575624-5");
        Book book2 = new Book("Liisan ihmeellinen maailma", "Matti.K", "KirjojaOy", 34.2, "978-7-22-456987-1");




            book1.ChangeTheme("Matkailu");
            book1.GetBookDetails("978-4-36-575624-5");
            Console.WriteLine();
            book2.GetBookDetails("978-7-22-456987-1");


        }
    }
}
