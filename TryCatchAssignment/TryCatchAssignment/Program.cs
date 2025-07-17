using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Asking the user for their age
                Console.WriteLine("Please enter your age:");
                //Taking the input, converting it into integer and assigning it to variable age
                int age = int.Parse(Console.ReadLine());
                //Displaying an error message if age = 0
                if (age == 0)
                {
                    Console.WriteLine("Error: Age must be a number greater than zero.");
                }
                //Displaying an error message if age < 0
                else if (age < 0) 
                {
                    Console.WriteLine("Error: Age must be a positive number.");
                }
                else
                {
                    //Calculating the year of birth
                    int yearOfBirth = DateTime.Now.Year - age;
                    //Displaying the year of birth of the user
                    Console.WriteLine("Your year of birth is: {0}", yearOfBirth);
                }                    
            }
            //Displaying an error message if age is not an integer
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter digits only, no decimals.");                
            }
            //Displaying an error message if something unexpected happens
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");               
            }
            Console.ReadLine();
        }
    }
}
