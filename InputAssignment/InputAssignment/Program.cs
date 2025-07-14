using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user for a number
            Console.WriteLine("Please, enter a number:");
            //Taking the input and assigning it to the variable number
            string number = Console.ReadLine();
            //Logging that number to a text file
            File.WriteAllText(@"C:\Users\amana\Documents\Logs\logNumber.txt", number);
            //Reading the content of the text file and assigning it to the variable text
            string text = File.ReadAllText(@"C:\Users\amana\Documents\Logs\logNumber.txt");
            //Printing the content of the text file back to the user
            Console.WriteLine(text + " is a nice number!");
            Console.ReadLine();
        }
    }
}
