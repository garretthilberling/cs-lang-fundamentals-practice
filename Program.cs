// using is similar to require or import
// without System, every time Console is used, it would need to be preceded by System and a period
using System;
// to use dictionaries:
using System.Collections.Generic;

// namespace is similar to modules in node.js
namespace CatWorx.BadgeMaker
// everything inside the curly braces can be interpreted as members of this namespace
{
    class Program
    {
        // static implies that the scope of this method is at the class level, not the object level
        // and can thus be invoked without having to first create a new class instance
        // Hence the Main() method can be run as soon as the program runs
        static void Main(string[] args) //Entry Point
        {
            // In C# it is necessary to use double quotes to define a string
            string greeting = "Hello";
            string hello = "Hello";
            string world = "World";
            string exclamation = "!";
            greeting += " World!";
            double side = 3.14;
            double area = side * side;
            Console.WriteLine($"greeting: {greeting}");
            Console.WriteLine("greeting: {0} {1}{2}", hello, world, exclamation);
            Console.WriteLine("area: {0}", area);

            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            Console.WriteLine(1 + 2 * 3);     // order of operations
            Console.WriteLine(10 / 3.0);      // int's and doubles
            Console.WriteLine(10 / 3);        // int's 
            Console.WriteLine("12" + "3");    // What happens here?

            int num = 10;
            num += 100;
            Console.WriteLine(num);
            num ++;
            Console.WriteLine(num);

            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

            string numString = "10"; 
            Console.WriteLine(numString + numString);
            int intNum = Convert.ToInt16(numString);
            Console.WriteLine(intNum + intNum);
            Console.WriteLine(intNum.GetType());
            // similar to js objects
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 10 },
                { "secondInning", 20},
                { "thirdInning", 30},
                { "fourthInning", 40},
                { "fifthInning", 50}
            };

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

            List<string> employees = new List<string>() { "adam", "amy" };

            employees.Add("barbara");
            employees.Add("billy");
            Console.WriteLine("Employees: {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
            // OR,
            for(int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            };

        }
    }
}