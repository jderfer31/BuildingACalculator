using System;

namespace BuildingACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to convert strings with numbers to actual numbers
            //int num = Convert.ToInt32("45"); //This converts the number inside of the string to an integer
            //Console.WriteLine(num + 6); //Using the num variable I can now add inside this string

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //gives error initially because this gives us a string and not an integer solve by inputting Convert.ToInt32
            Console.Write("Enter another number: "); //Copied from first line to gather another number
            int num2 = Convert.ToInt32(Console.ReadLine()); //Changed num1 variable to num2

            Console.WriteLine(num1 + num2);

            //If you want program to accept decimal numbers do the following:
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); //gives error initially because this gives us a string and not an integer solve by inputting Convert.ToInt32
            Console.Write("Enter another number: "); //Copied from first line to gather another number
            double num2 = Convert.ToDouble(Console.ReadLine()); //Changed num1 variable to num2

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
