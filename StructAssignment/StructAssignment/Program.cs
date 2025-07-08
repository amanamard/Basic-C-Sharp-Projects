using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //An object of data type Number
            Number number = new Number();
            //Assigning an amount to the object
            number.Amount = 100000m;
            //Printing the amount
            Console.WriteLine("My annual salary is: " + "$" + number.Amount);
            Console.ReadLine();
        }
    }
}
