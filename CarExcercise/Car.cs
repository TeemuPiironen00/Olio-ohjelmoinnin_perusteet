using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExcercise
{
    internal class Car
    {
        public string? brand;
        public int? speed;

    public Car()
        {
            this.brand = "";
            this.speed = 0;
        }

        internal void Accelerate()
        {
            Console.WriteLine("Paljonko nopeutta lisätään?");
            int speed1 = 0;
            int.TryParse(Console.ReadLine(), out speed1);
            this.speed += speed1;
            Console.WriteLine(this.brand + ":n nopeus muutoksen jälkeen on " + this.speed);
        }
        internal void AskData()
        {
            Console.WriteLine("merkki");
            this.brand = Console.ReadLine();
            Console.WriteLine("nopeus");
            this.speed = int.Parse(Console.ReadLine());
        }

        internal void ShowCarInfo()
        {
            Console.WriteLine($"brand: {this.brand}, speed: {this.speed}, ");
        }
    }

    




}
