using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the question asking the age
            Console.WriteLine("What is your age?");
            //Taking the input, converting it into integer and assigning it to the variable age
            int age = Convert.ToInt32(Console.ReadLine());
            
            //Printing the question asking about the DUI
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            //Taking the input, convert it into boolean and assigning it to the variable dui
            bool dui = Convert.ToBoolean(Console.ReadLine());
            
            //Printing the question about the speeding tickects
            Console.WriteLine("How many speeding tickets do you have?");
            //Taking the input, convert it into integer and assigning it to the variable speedingTickets
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            
            //Determining whether or not the applicant qualified for car insurance
            Console.WriteLine("Qualified?");
            //Qualification rules
            bool qualified = age > 15 && dui == false && speedingTickets <= 3;
            Console.WriteLine(qualified);
            
            Console.ReadLine();
        }
    }
}
