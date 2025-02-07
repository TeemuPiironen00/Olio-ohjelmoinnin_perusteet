using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExcercise
{
    abstract class Shape
    {

        protected string type;
        protected string color;

        protected Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        public abstract double GetArea();
        public abstract string GetInfo();

        public string GetColor()
        {
        return this.color;

        }

    }
















    
}
