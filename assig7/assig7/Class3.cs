using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig7
{
    internal class Trapezium : Rectangle
    {
        private float base2;
        public float Base2 { get { return base2; } set { if (value > 0 ) base2 = value; } }
        public Trapezium (double @base,double hight,float base2) : base(@base, hight)
        {
            Base2 = base2;
        }
        public override string shape()
        {
            
            return "Trapezium";
        }
        public override void Area()
        {
            Console.WriteLine($"Area = {(Base + base2 / 2) * Height}");
        }
        public override string ToString()
        {
            return $"shape : {shape()}\tbase1 = {Base}\tbase2 = {base2}\thight = {Height}\tarea = {(Base + base2 / 2) * Height}";
        }
    }
}
