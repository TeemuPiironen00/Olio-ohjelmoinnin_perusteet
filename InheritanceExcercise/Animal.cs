using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    internal class Animal
    {
        protected string name = string.Empty; 
        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public override bool Equals(object? obj)
        {
            Animal? animal = obj as Animal;
            
            return (animal != null)
                && (this.name == animal.name);
        
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual void Speak() // animal speaks method
        {
            Console.WriteLine("Animal speaks");
        }

        public override string ToString() // animal to string method
        {
            return $"{ this.name} ";
        }




















    }
}