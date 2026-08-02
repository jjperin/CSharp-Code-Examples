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
            Maths.run();
            DataTypes.run();
            Classes.Classes.run();
            Inheritance.Inheritance.run();
            Collections.Collections.run();
            Exception_Handling.ExceptionHandling.run();
        }
    }
}
 