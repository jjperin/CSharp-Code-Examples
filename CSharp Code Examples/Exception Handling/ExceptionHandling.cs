using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Exception_Handling
{
    internal class ExceptionHandling
    {
        //Authors: Jake Peringatt
        //Shows off try catch blocks to handle exceptions, by performing division by iterating through an array of numbers (exception is the division by zero).

        public static void run()
        {
            Console.WriteLine("\nAn array of numbers, testing exception handling. The division by 0 should throw an error.");
            int[] numbers = { 0, 2, 4, 6, 8};
            foreach (int number in numbers)
            {
                try
                {
                    int result = 24 / number;
                    Console.WriteLine($"4 / {number} = {result}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Cannot divide by Zero: " + e.Message);
                }
            }
            Console.WriteLine();
        }
    }
}
