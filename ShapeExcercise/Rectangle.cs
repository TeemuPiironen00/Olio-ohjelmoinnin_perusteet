﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExcercise
{
    internal class Rectangle : Shape
    {
     private double length;
     private double width;

        public Rectangle(string type, string color, double length, double width) : base(type, color)
        {
            this.length = length;
            this.width = width;

        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override double GetArea()
        {
            double area = length * width;
            return area;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string GetInfo()
        {
        
            return $"Type: {type}, Color: {color}, Length: {length}, Width: {width}, Area: {GetArea()}";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
