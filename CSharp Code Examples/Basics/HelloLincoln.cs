using CSharp_Code_Examples.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class HelloLincoln
    {
        //Authors: Mark Doughty
        //Prints a string and shows todays date in the console

        public static void run()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Hello Lincoln!");
            Console.WriteLine("Today's date is " + date.ToLongDateString());

            bool running = true;
            while (running)
            {
                running = cliMenu();
            }

        }

        public static bool cliMenu()
        {
            Console.WriteLine("C# Examples Menu. Please type the number of the menu you want to open");
            string[] menuItems = { "Maths", "DataTypes", "Sorts", "Classes", "Inheritance", "Collections", "Excepition Handling", "Exit" };
            int index = 1;
            foreach (string item in menuItems)
            {
                Console.WriteLine(index + ". " + item);
                index++;
            }

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": Maths.run(); break;
                case "2": DataTypes.run(); break;
                case "3": Sorts.run(); break;
                case "4": Classes.Classes.run(); break;
                case "5": Inheritance.Inheritance.run(); break;
                case "6": Collections.Collections.run(); break;
                case "7": Exception_Handling.ExceptionHandling.run(); break;
                case "8": 
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    return false;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
            return true;  
        }
    }
}
 