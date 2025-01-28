using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    internal class Cat: Animal
    {
        public bool isIndoor = false; //cat is indoor or outdoor
        public Cat(string name, bool isIndoorCat) : base(name)
        {
            this.isIndoor = isIndoorCat;
        }

        public override void Speak()
        {
            Console.WriteLine($"{this.name} says Meow"); //cat speaks method
        }

        public override string ToString() 
        {
            if (this.isIndoor) //if cat is indoorcat print sisäkissa
            {
                return $"{base.ToString()}, sisäkissa";
            }
            else
            {
                return $"{base.ToString()}, ulkokissa";
            }
            
        }
    }
}
