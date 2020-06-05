// Made by Jordan Leich on 6/5/2020

using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;

            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Enter your operation ( +, -, *, / ): ");
            operation = Console.ReadLine();
            Console.WriteLine("");

            if (operation == "+" | operation == "add") 
            {
                int result = (number1 + number2);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("");
            }
             
            else if (operation == "-" | operation == "subtract")
            {
                int result = (number1 - number2);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("");
            }

            else if (operation == "*" | operation == "multiply")
            {
                int result = (number1 * number2);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("");
            }

            else if (operation == "/" | operation == "divide")
            {
                int result = (number1 / number2);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Invalid input... ending program now...");
                Console.WriteLine("");
                Thread.Sleep(3000);
                System.Environment.Exit(0);
            }
        }
    }
}
