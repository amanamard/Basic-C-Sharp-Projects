using System;

namespace BranchingAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Printing the message asking to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            //Taking the input, converting it into integer and assigning it to the variable weight
            int weight = Convert.ToInt32(Console.ReadLine());

            //Shipping rule
            if (weight > 50)
            {
                //Printing the error message when the weight is greater than 50
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //Printing the message asking to enter the package width
                Console.WriteLine("Please enter the package width:");
                //Taking the input, converting it into integer and assigning it to the variable width
                int width = Convert.ToInt32(Console.ReadLine());
                //Printing the message asking to enter the package height
                Console.WriteLine("Please enter the package height:");
                //Taking the input, converting it into integer and assigning it to the variable height
                int height = Convert.ToInt32(Console.ReadLine());
                //Printing the message asking to enter the package length
                Console.WriteLine("Please enter the package length:");
                //Taking the input, converting it into integer and assigning it to the variable length
                int length = Convert.ToInt32(Console.ReadLine());

                //Dimensions rule
                int total = width + height + length;

                if (total > 50)
                {
                    //Displaying the error message when the dimensions total is greater than 50
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else 
                {
                    //Calculation of the quote
                    decimal quote = ((width * height * length) * weight) / 100;
                    //Displaying the quote as a dollar amount
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quote + ".00" + "\nThank you!");
                }
            }
            
            Console.ReadLine();
        }
    }
}
