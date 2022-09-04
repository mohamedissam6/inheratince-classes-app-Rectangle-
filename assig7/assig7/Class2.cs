using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig7
{
    internal class Parallelogram : Rectangle
    {
        public Parallelogram(double @base, double height) : base(@base, height)
        {
        }
        public override string shape()
        {
           
            return "parallelogram";
            
        }
    }
}
