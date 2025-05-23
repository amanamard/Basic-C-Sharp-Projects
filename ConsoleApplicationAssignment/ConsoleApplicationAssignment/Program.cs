using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take an input from the user, multiply it by 50, then print the result
            Console.WriteLine("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double product = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product.ToString());
            
            //Take an input from the user, adds 25 to it, then print the result
            Console.WriteLine("Enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double add = num2 + 25;
            Console.WriteLine("Your number plus 25 is: " + add.ToString());
            
            //Take an input from the user, divide it by 12.5, then print the result
            Console.WriteLine("Enter a third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double divide = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + divide.ToString());

            //Take an input from the user, check if it is greater than 50, then print the true/false result
            Console.WriteLine("Enter a fourth number:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            bool isGreatherThanFifty = num4 > 50;
            Console.WriteLine("True or False, your number is greater than fifty? " + isGreatherThanFifty);

            //Take an input from the user, divide it by 7, then print the remainder
            Console.WriteLine("Enter a fifth number:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine("The remainder of your number divided by seven is: " + remainder.ToString());

            Console.ReadLine();
        }
    }
}
