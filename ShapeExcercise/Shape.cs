using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExcercise
{
    abstract class Shape : IComparable<Shape>
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

        public int CompareTo(Shape? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            // Compare shapes based on their areas
            double thisArea = GetArea();
            double otherArea = other.GetArea();

            if (thisArea < otherArea)
            {
                return 1;
            }
            else if (thisArea > otherArea)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
















    
}
