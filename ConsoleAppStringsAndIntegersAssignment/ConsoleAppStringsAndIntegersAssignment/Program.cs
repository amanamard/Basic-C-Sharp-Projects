using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //A list of integers
        List<int> numbers = new List<int>() { 7, 15, 9, 26, 15, 21, 20, 2023 };
        bool validNumber = false;
        while (!validNumber)
        {
            //Using try/catch block to give error message       
            try
            {
                //Asking the user for a number
                Console.WriteLine("\nEnter a number:");
                //Taking the input, converting it into float and assigning it to the variable num
                float num = float.Parse(Console.ReadLine());
                //Checking if the user's input is 0
                if (num == 0)
                {
                    Console.WriteLine("\nPlease enter a number other than zero!");
                }
                else
                {
                    //Dividing each number in the list by the user's input, and displaying the result to the screen
                    foreach (int number in numbers)
                    {
                        float result = number / num;
                        Console.WriteLine("\n" + number + " / " + num + " = " + result);
                    }
                    validNumber = true;
                }
            }
            //Catch block to display error message when user enter a string
            catch (FormatException ex)
            {
                Console.WriteLine("\nInvalid input! Please enter a number.");
            }
            //Catch block to display other errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Message to let the user know the program has emerged from the try/catch block
        Console.WriteLine("\nThe program has emerged from the try/catch block...");
    }
}
