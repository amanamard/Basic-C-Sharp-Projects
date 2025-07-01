using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter a first number
            Console.WriteLine("Please, enter a whole number:");
            //Taking the input, converting it into integer and assigning it to variable num1
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Calling Add() method of the class MathOperation with num1 as argument and assigning the result to variable a
            int a = MathOperation.Add(num1);
            //Printing the result of Add() method with num1 as argument
            Console.WriteLine("\n" + num1 + " + " + "5" + " = " + a);

            //Asking the user to enter a second number
            Console.WriteLine("\nPlease, enter a second whole number:");
            //Taking the input, converting it into integer and assigning it to variable num2
            int num2 = Convert.ToInt32(Console.ReadLine());
            //Calling Subtract() method of the class MathOperation with num2 as argument and assigning the result to variable b
            int b = MathOperation.Subtract(num2);
            //Printing the result of Subtract() method with num2 as argument
            Console.WriteLine("\n" + num2 + " - " + "5" + " = " + b);

            //Asking the user to enter a third number
            Console.WriteLine("\nPlease, enter a third whole number:");
            //Taking the input, converting it into integer and assigning it to variable num3
            int num3 = Convert.ToInt32(Console.ReadLine());
            //Calling Multiply() method of the class MathOperation with num3 as argument and assigning the result to variable c
            int c = MathOperation.Multiply(num3);
            //Printing the result of Subtract() method with num3 as argument
            Console.WriteLine("\n" + num3 + " * " + "5" + " = " + c);
            Console.ReadLine();            
        }
    }
}
