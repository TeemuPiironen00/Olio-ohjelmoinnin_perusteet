using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExcercise
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string type, string color, double radius) : base(type, color)
        {
            this.radius = radius;
        }

        public override string GetInfo()
        { 
            return $"Type: {type}, Color: {color}, Radius: {radius}, Area: {GetArea()}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
