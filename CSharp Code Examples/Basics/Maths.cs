using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class Maths
    {
        //Authors: Mark Doughty, Jake Peringatt
        //Some mathematics function examples
        public static void run()
        {
            //Pythagoras
            //c^2 = a^2 + b^2
            int a = 3;
            int b = 4;
            double Pythag_squared = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine("Hypoteneuse = " + Math.Sqrt(Pythag_squared));

            //Law of Cosines - for when triangle doesn't have a right angle
            //C is the angle opposite c
            //c^2 = a^2 + b^2 - 2*a*b*cos(C)
            double C = 40.0;
            double cRad = C * Math.PI / 180; 
            double LoC_squared = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(cRad));
            Console.WriteLine("Unknown side is = " + Math.Round(Math.Sqrt(LoC_squared), 2));


            //Circles
            //PI * R^2
            double radius = 5;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is = " + Math.Round(area, 2));
        }
    }
}
