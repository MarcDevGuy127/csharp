using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudies.Fundamentals
{
    public class Casting
    {
        public static void Run()
        {
            // Implict Casting
            int myInt = 15;
            double myDouble = myInt;

            Console.WriteLine("Implict Casting");
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explict Casting
            double mySecondDouble = 10.79;
            int mySecondInt = (int) 9.79;

            Console.WriteLine("Implict Casting");
            Console.WriteLine(mySecondInt);
            Console.WriteLine(mySecondDouble);

            // Type Conversion Methods
            int myIntValue = 10;
            double myDoubleValue = 5.25;
            bool myBoolValue = true;

            Console.WriteLine("Type Conversion Methods");
            Console.WriteLine(Convert.ToString(myIntValue));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntValue));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleValue));  // convert double to int
            Console.WriteLine(Convert.ToString(myBoolValue));   // convert bool to string
        }
    }
}
