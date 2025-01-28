using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    internal class Dog : Animal
    {
        public bool isTrained = false;
        public Dog(string name, bool isTrainedDog) : base(name)
        {
            this.isTrained = isTrainedDog;

        }

        public override void Speak()
        {
            Console.WriteLine($"{this.name} says Woof");
        }
        public override string ToString() // dog to string method
        {
            if (this.isTrained)
            {
                return $"{base.ToString()}, koulutettu koira";
            }
            else
            {
                return $"{base.ToString()}, kouluttamaton koira";
            }
        }
    }
}
