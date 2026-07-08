using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Fundamentals
{
    public class Variables
    {
        public static void Run()
        {
            string name = "Marcelo";
            int age = 20;
            double myMoney = 278.99D;
            char firstLetter = 'M';
            bool myBool = true;

            Console.WriteLine("Variables example");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(myMoney);
            Console.WriteLine(firstLetter);
            Console.WriteLine(myBool);
        }
    }
}
