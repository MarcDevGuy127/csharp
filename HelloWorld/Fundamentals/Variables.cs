using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudies.Fundamentals
{
    public class Variables
    {
        public static void Run()
        {
            int x, y, z;
            x = y = z = 50; // same value for these variables
            string name = "Marcelo";
            int age = 20;
            double myMoney = 278.99D;
            long pocket = 15000000000L;
            char firstLetter = 'M';
            bool myBool = true;
            const string university = "UNIBRASIL";

            Console.WriteLine("Variables example");
            Console.WriteLine(name);
            Console.WriteLine(university);
            Console.WriteLine(age);
            Console.WriteLine(myMoney);
            Console.WriteLine(pocket);
            Console.WriteLine(firstLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(x + y + z);
        }
    }
}
