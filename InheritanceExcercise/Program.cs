namespace InheritanceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Fluffy", true);
            Cat cat2 = new Cat("Muffin", false);
            Console.WriteLine(cat1.ToString());
            Console.WriteLine(cat2.ToString());

            cat1.Speak();
            cat2.Speak();

            Dog dog1 = new Dog("Masi", true);
            Dog dog2 = new Dog("Maaasi", false);
            Console.WriteLine(dog1.ToString());
            Console.WriteLine(dog2.ToString());

            dog1.Speak();
            dog2.Speak();



            dog1.Equals(dog2);
            cat2.Equals(cat1);










        }
    }
}
