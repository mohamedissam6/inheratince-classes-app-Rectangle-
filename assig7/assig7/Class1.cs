using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig7
{
    internal class Rectangle
    {
        public double Base;
        public double Height;
            public double @base {get {return Base;} set {if (value > 0)  Base = value;}}
            public double height{get {return Height;} set {if (value > 0) Height = value;}}

        public Rectangle(double @base, double height)
        {
            this.@base = @base;
            this.height = height;
        } 

        public virtual void Area()
        {
            Console.WriteLine($"Area = {Base * Height}");
        }
        public virtual string shape()
        {
            
            return ("rectangle");
        }
        public override string ToString()
        {
            return($"shape : {shape()}\tbase = {Base}\thight : {Height}\tArea : {Base * Height}");
        }
    }
}
