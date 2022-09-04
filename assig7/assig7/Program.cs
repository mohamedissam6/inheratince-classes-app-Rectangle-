using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle [] array=new Rectangle[5];
            array[0] = new Rectangle(-5, 12);
            array[1] = new Parallelogram(9, 11);
            array[2] = new Parallelogram(10, -4);
            array[3] = new Trapezium(10, 12,8);
            array[4] = new Trapezium(12, -2,9);
            foreach (Rectangle r in array)
            {
                Console.WriteLine(r);
            }
        }
    }
}
