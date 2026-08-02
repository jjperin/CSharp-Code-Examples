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
        //Some data type uses in C#
        public static void run()
        {
            //basic variables
            int int_ = 5;
            double double_ = 12.5;
            string string_ = "abc";
            char char_ = 'A';
            bool bool_ = false;
            Console.WriteLine($"int: {int_}, double: {double_}, string: {string_}, char: {char_}, bool: {bool_}");


            //implicit casting 
            double implicitCasting = int_;
            Console.WriteLine("Int implicitly casteded to a Double: " + implicitCasting);

            //explicit casting
            int explicitCast = (int)double_;
            Console.WriteLine("Double explicitly casted to an Int " + explicitCast);

            //converting types

            string numberString = "123";
            int convertInt = Convert.ToInt32(numberString);
            Console.WriteLine("String converted to an Int: " + convertInt);

            //safe conversion
            string goodString = "456";
            string badString = "hello";

            stringToIntParse(goodString);
            stringToIntParse(badString);

        }

        static void stringToIntParse(string inputString)
        {
            if(int.TryParse(inputString, out int result))
            {
                Console.WriteLine("String parsed to integer successfully: " + result);
            }
            else
            {
                Console.WriteLine("String " + inputString + " could not be parsed");
            }
        }
    }
}
