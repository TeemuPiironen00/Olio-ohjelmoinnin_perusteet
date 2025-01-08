namespace BugExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
        }
    }
}
