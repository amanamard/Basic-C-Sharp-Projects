using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);
            //Asking the user for a number
            Console.WriteLine("Please, enter a number to see the exact time it will be in hours:");
            Double x = Convert.ToDouble(Console.ReadLine());
            //Printing the exact time it will be in hours
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, x, DateTime.Now.AddHours(x));
            Console.ReadLine();
        }
    }
}
