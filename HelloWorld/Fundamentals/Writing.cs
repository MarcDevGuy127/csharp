using System;

namespace CSharpStudies.Fundamentals
{
    public class Writing
    {
        public static void Run()
        {
            // WriteLine creates a new line at the end
            // Write doesn't create a new line
            Console.Write("Hello World! with Write");
            Console.WriteLine("Hello World! with WriteLine");
            Console.Write("Hello World! with Write");

            // You can also do arithmetic operations
            Console.WriteLine(6 + 6);
        }
    }
}