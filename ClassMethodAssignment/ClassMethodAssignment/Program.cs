using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class IntegerMethod
            IntegerMethod method = new IntegerMethod();
            //Asking the user to enter a number
            Console.WriteLine("Enter an integer: ");
            //Taking the input, converting it into integer and assigning to variable num
            int num = Convert.ToInt32(Console.ReadLine());
            //Calling the method on num
            method.IntegerOperation(num);
            Console.ReadLine();

        }
    }
}
