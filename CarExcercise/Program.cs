namespace CarExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();



            car1.AskData();
            Console.WriteLine();
            car1.ShowCarInfo();
            Console.WriteLine();
            
            car2.AskData();
            Console.WriteLine();
            car2.ShowCarInfo();
            Console.WriteLine();

            car1.Accelerate();
            Console.WriteLine();
            car2.Accelerate();






        }
    }
}
