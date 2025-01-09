namespace BookExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            Student studentA = new Student();
            studentA.firstName = "Anni";
            studentA.lastName = "Piiska";
            studentA.SetAge(18);
            studentA.PrintInformation();
            //Console.WriteLine($"Etunimi: {studentA.firstName}, Sukunimi: {studentA.lastName}, {studentA.age}");
            //studentA.PrintInformation();
            Student studentB = new Student();
            studentB.firstName = "Mikko";
            studentB.lastName = "Puuska";
            studentB.SetAge(12);
            studentB.PrintInformation();
            //Console.WriteLine($"Etunimi: {studentB.firstName}, Sukunimi: {studentB.lastName}, {studentB.age}");
            Student studentC = new Student("Maisa", "Karisaari", 19);
            studentC.PrintInformation();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Book book1 = new Book("Maisan maailma", "Liisu.M", "02230", 23);
            Book book2 = new Book("Lissun Linna", "Maija.M", "10000", 25);

            book1.BookPrint();
            Console.WriteLine();
            book2.BookPrint();

            book1.CompareBook(book2);




        }
    }
}
