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
        //Some mathematics function examples. Pythagoras, Law of Cosines, Circle Area, Quadratic Formula. 
        public static void run()
        {
            Console.WriteLine("\nMaths Menu. Please type the number of the menu you want to open");
            string[] menuItems = { "Pythagoras", "Law Of Cosines", "Circles", "Quadratic Formula", "Exit"};
            int index = 1;
            foreach (string item in menuItems)
            {
                Console.WriteLine(index + ". " + item);
                index++;
            }

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": Pythagoras(); break;
                case "2": LawOfCosines(); break;
                case "3": Circles(); break;
                case "4": QuadraticFormula(); break;
                case "5": HelloLincoln.run(); break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    run();
                    break;
            }
        }

        public static void Pythagoras()
        {
            //Pythagoras
            //c^2 = a^2 + b^2

            double a = Math.Abs(ValidDouble("Enter side a: "));
            double b = Math.Abs(ValidDouble("Enter side b: "));
            double Pythag_squared = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine("Hypoteneuse = " + Math.Sqrt(Pythag_squared));

            HelloLincoln.run();

        }

        public static void LawOfCosines()
        {
            //Law of Cosines - for when triangle doesn't have a right angle
            //C is the angle opposite c
            //c^2 = a^2 + b^2 - 2*a*b*cos(C)

            double a = Math.Abs(ValidDouble("Enter side a: "));
            double b = Math.Abs(ValidDouble("Enter side b: "));
            double C;
            while (true)
            {
                C = ValidDouble("Enter angle C in degrees: ");
                if (C < 180 && C > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a valid angle for C, less than 180 degrees and more than 0");
                }
            }
            double cRad = C * Math.PI / 180;
            double LoC_squared = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(cRad));
            Console.WriteLine("Unknown side is = " + Math.Round(Math.Sqrt(LoC_squared), 2));

            HelloLincoln.run();
        }

        public static void Circles()
        {
            //Circles
            //PI * R^2
            double radius = Math.Abs(ValidDouble("Please enter a number for the radius for the circle"));
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is = " + Math.Round(area, 2));

            HelloLincoln.run();
        }

        public static void QuadraticFormula()
        {

            //Quadratic Formula
            //ax^2 + bx + c = 0 
            //x = (-b +/- Sqrt(b^2 - 4ac)) / 2a

            double quadA = ValidDouble("Enter the 'a' coefficient: ");
            double quadB = ValidDouble("Enter the 'b' coefficient: ");
            double quadC = ValidDouble("Enter the 'c' coefficient: ");

            //Discriminant = b^2 - 4ac
            double discriminant = Math.Pow(quadB, 2) - (4 * quadA * quadC);


            if (Math.Abs(quadA) < 0.000001) //floating point values can be inaccurate, so comparing directly to 0 may fail. this is to mitigate it.
            {
                Console.WriteLine("Not a quadratic");
            }
            else if (Math.Abs(discriminant) < 0.000001)
            {
                double root1 = (-quadB + Math.Sqrt(discriminant)) / (2 * quadA);
                Console.WriteLine("One quadratic root: " + root1);
            }
            else if (discriminant > 0.000001)
            {
                double root1 = (-quadB + Math.Sqrt(discriminant)) / (2 * quadA);
                double root2 = (-quadB - Math.Sqrt(discriminant)) / (2 * quadA);
                Console.WriteLine("Two quadratic roots: " + root1 + ", " + root2);
            }
            else
            {
                Console.WriteLine("No real quadratic roots exist");
            }

            HelloLincoln.run();
        }


        public static double ValidDouble(string Output)
        {
            double result;
            while (true)
            {
                Console.WriteLine(Output);
                string input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid number. Try again");
                }
            }
            return result;

        }


    }
}
