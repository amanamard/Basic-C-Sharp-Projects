using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating a one-dimensional Array of strings
        string[] firstNameArray = { "Mardochee", "Monique", "Marc", "Jeremie", "Annabelle", "Ariane", "Benjamin" };
        
        //Asking the user to select an index of the Array
        Console.WriteLine("Please, enter a number between 0 and 6:");
        //Taking the input, converting it into integer and assigning it to the variable selectIndex1
        int selectIndex1 = Convert.ToInt32(Console.ReadLine());

        //Displaying the string corresponding to the index of the Array
        bool validString = false;
        while (!validString)
        {
            try
            {
                Console.WriteLine("Your favorite first name is: " + firstNameArray[selectIndex1]);
                validString = true;
            }
            //Message displayed when the user select an index that doesn't exist
            catch 
            {
                Console.WriteLine("Sorry, that number is invalid! Please select a number between 0 and 6.");
                selectIndex1 = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Creating a one-dimensional Array of integers
        int[] intArray = { 7, 15, 9, 26, 15, 20, 21 };

        //Asking the user to select an index of the Array
        Console.WriteLine("\nPlease, enter a second number between 0 and 6:");
        //Taking the input, converting it into integer and assigning it to the variable selectIndex2
        int selectIndex2 = Convert.ToInt32(Console.ReadLine());

        //Displaying the integer corresponding to the index of the Array
        bool validInteger = false;
        while (!validInteger)
        {
            try
            {
                Console.WriteLine("Your favorite number is: " + intArray[selectIndex2]);
                validInteger = true;
            }
            //Message displayed when the user select an index that doesn't exist
            catch
            {
                Console.WriteLine("Sorry, that number is invalid! Please select a number between 0 and 6.");
                selectIndex2 = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Creating a list of strings
        List<string> cityList = new List<string>()
        {
            "Brampton",
            "Mississauga",
            "Toronto",
            "Guelph",
            "Ottawa",
            "Orangeville",
            "Hamilton"
        };

        //Asking the user to select an index of the list
        Console.WriteLine("\nPlease, enter a third number between 0 and 6:");
        //Taking the input, converting it into integer and assigning to the variable selectIndex3
        int selectIndex3 = Convert.ToInt32(Console.ReadLine());

        //Displaying the content corresponding to the index of the list
        bool validCity = false;
        while (!validCity)
        {
            try
            {
                Console.WriteLine("Your favorite city is: " + cityList[selectIndex3]);
                validCity = true;
            }
            //Message displayed when the user select an index that doesn't exist
            catch
            {
                Console.WriteLine("Sorry, that number is invalid! Please select a number between 0 and 6.");
                selectIndex3 = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.ReadLine();

    }
}
