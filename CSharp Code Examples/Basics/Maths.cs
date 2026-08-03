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

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMaths Menu. Please type the number of the menu you want to open");
                string[] menuItems = { "Pythagoras", "Law Of Cosines", "Circles", "Quadratic Formula", "Exit" };
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
                    case "5": running = false; break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }

        public static void Pythagoras()
        {
            //Pythagoras
            //c^2 = a^2 + b^2

            double a = Math.Abs(ValidDouble("Enter side a: "));
            double b = Math.Abs(ValidDouble("Enter side b: "));
            double c = CalculateHypotenuse(a, b);
            Console.WriteLine("Hypoteneuse = " + c);


        }

        public static double CalculateHypotenuse(double a, double b)
        {
            double cSquared = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Math.Sqrt(cSquared);
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


            double unknownSide = CalculateLawOfCosines(a, b, C);
            Console.WriteLine("Unknown side is = " + unknownSide);

        }

        public static double CalculateLawOfCosines(double a, double b, double C)
        {
            double cRad = C * Math.PI / 180;
            double LoC_squared = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(cRad));
            return Math.Sqrt(LoC_squared);
        }

        public static void Circles()
        {
            //Circles
            //PI * R^2
            double radius = Math.Abs(ValidDouble("Please enter a number for the radius for the circle"));
            double area = CalculateArea(radius);
            Console.WriteLine("The area of the circle is = " + Math.Round(area, 2));

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI* Math.Pow(radius, 2);
        }

        public static void QuadraticFormula()
        {

            //Quadratic Formula
            //ax^2 + bx + c = 0 
            //x = (-b +/- Sqrt(b^2 - 4ac)) / 2a

            double quadA = ValidDouble("Enter the 'a' coefficient: ");
            double quadB = ValidDouble("Enter the 'b' coefficient: ");
            double quadC = ValidDouble("Enter the 'c' coefficient: ");

            double discriminant = CalculateDiscrimant(quadA,quadB,quadC);


            if (Math.Abs(quadA) < 0.000001) //floating point values can be inaccurate, so comparing directly to 0 may fail. this is to mitigate it.
            {
                Console.WriteLine("Not a quadratic");
            }
            else if(discriminant < -0.000001)
            {
                Console.WriteLine("No real quadratic roots exist");
            }
            else if(Math.Abs(discriminant) < 0.000001)
            {
                double[] roots = CalculateRoot(quadA, quadB, discriminant);
                Console.WriteLine("One quadratic root: " + roots[0]);
            }
            else
            {
                double[] roots = CalculateRoot(quadA, quadB, discriminant);
                Console.WriteLine("Two quadratic roots: " + roots[0] + ", " + roots[1]);
            }

        }

        public static double CalculateDiscrimant(double quadA, double quadB, double quadC)
        {
            //Discriminant = b^2 - 4ac

            return Math.Pow(quadB, 2) - (4 * quadA * quadC);
        }
        public static double[] CalculateRoot(double quadA, double quadB, double discriminant)
        {
            //Quadratic Formula
            //ax^2 + bx + c = 0 
            //x = (-b +/- Sqrt(b^2 - 4ac)) / 2a
            double root1 = (-quadB + Math.Sqrt(discriminant)) / (2 * quadA);
            double root2 = (-quadB - Math.Sqrt(discriminant)) / (2 * quadA);
            return new double[] { root1, root2 };

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
