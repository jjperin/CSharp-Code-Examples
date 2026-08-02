using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class DataTypes
    {
        //Authors: Mark Doughty, Jake Peringatt
        //Some data type uses in C#, casting and conversion
        public static void run()
        {
            //basic variables
            int int_ = 5;
            double double_ = 12.5;
            string string_ = "abc";
            char char_ = 'A';
            bool bool_ = false;
            Console.WriteLine("Datatypes: ");
            Console.WriteLine($"int: {int_}, double: {double_}, string: {string_}, char: {char_}, bool: {bool_}");


            //implicit casting 
            Console.WriteLine("\n\nImplicit casting (Int to Double)");
            double implicitCasting = int_;
            Console.WriteLine("\nInt implicitly casteded to a Double: " + implicitCasting);

            //explicit casting
            Console.WriteLine("\n\nExplicit casting (Double to Int)");
            int explicitCast = (int)double_;
            Console.WriteLine("\nDouble explicitly casted to an Int " + explicitCast);

            //converting types
            Console.WriteLine("\n\nConverting String to Int");
            string numberString = "123";
            int convertInt = Convert.ToInt32(numberString);
            Console.WriteLine("\nString converted to an Int: " + convertInt);

            //safe conversion
            Console.WriteLine("\n\nSafe converting string to int, safely handle unparsable strings");
            string goodString = "456";
            string badString = "hello";

            stringToIntParse(goodString);
            stringToIntParse(badString);

            Thread.Sleep(1000); //waits 1 second before going back to original menu
        }

        static void stringToIntParse(string inputString)
        {
            if(int.TryParse(inputString, out int result))
            {
                Console.WriteLine("\nString parsed to integer successfully: " + result);
            }
            else
            {
                Console.WriteLine("\nString " + inputString + " could not be parsed");
            }
        }
    }
}
