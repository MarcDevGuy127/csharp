Console.WriteLine("Hello, World!");

// CHALLENGE
// Write code in the C# Code Editor to display two messages
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

// using int literal
Console.WriteLine(123);

// WriteLine() X Write()

// using WriteLine() method, appends lines after print
Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");

// using Write() method, print in line
Console.Write("1");
Console.Write("2");
Console.WriteLine("3");

// Creating variables
string firstName = "Bob";
Console.WriteLine(firstName);

// Implicitly variable
// Caution: the var type is locked when declared
var message = "Hello World!";

// CHALLENGE
/*
 * Store the following values in variables:

Bob
3
34.4
These variables should be given names that reflect their purpose.

Make sure you select the correct data type for each of the variables based on the type of data it will hold.

Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.

Write code in the C# Code Editor to display the following message:

Output
Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
 */

string name = "Bob";
int counter = 3;
double temperature = 34.4;

Console.Write("Hello, " + name + "!");
Console.Write("You have " + counter + " messages in your inbox.");
Console.Write("The temperature is " + temperature + " celsius.");