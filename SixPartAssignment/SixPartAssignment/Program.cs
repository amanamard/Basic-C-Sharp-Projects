using System;
using System.Collections.Generic;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Assignment Part 1
            //A one-dimensional array of strings
            string[] stringsArray = { "Hello ", "Welcome ", "Have a nice day " };
            //Asking the user to enter his name
            Console.WriteLine("Please, enter your name:");
            //Taking the input, converting it to uppercase and assigning it to the variable name
            string name = Console.ReadLine().ToUpper();
            //Iteration through each string in stringsArray
            for (int i = 0; i < stringsArray.Length; i++) 
            {
                //Addition of user's input to the end of each string
                stringsArray[i] = stringsArray[i] + name;
            }
            //Loop that prints off each string in the array one at a time
            for (int j = 0; j < stringsArray.Length; j++) 
            {
                Console.WriteLine(stringsArray[j]);
            }
            Console.ReadLine();

            //Console App Assignment Part 2
            //An infinite for loop
            //for ( ; ; )
            //{
            //    Console.WriteLine("Hello, there!");
            //}
            //The infinite loop was fixed by:
            //adding and initializing the variable k (int k = 0)
            //setting the condition to end the loop (K < 5)
            //incrementing the variable k after each loop (k++)
            //
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("\nHello, there!");
            }
            Console.ReadLine();

            //Console App Assignment Part 3
            //Loop where "<" is the operator to set iterating condition
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("\nLoop " + x);
            }
            //Loop where "<=" is the operator to set iterating condition
            for (int y = 0; y <= 5; y++)
            {
                Console.WriteLine("\nLoop " + y);
            }
            Console.ReadLine();

            //Console App Assignment Part 4
            //A list of strings where each item in the list is unique
            List<string> names = new List<string>()
            {
                "MARDOCHEE",
                "TIMOTHEE",
                "BARUCH",
                "JOEL",
                "EMILE",
                "MAXIMILIEN"
            };
            //Asking the user to input text to search for in the list
            Console.WriteLine("\nPlease, enter a name to guess one of my brother's name:");
            //Taking the input, converting it to uppercase and assigning it to the variable guess
            string guess = Console.ReadLine().ToUpper();
            //A loop that iterates through the list
            bool validName = false;
            for (int i = 0; i < names.Count; i++) 
            {
                if (guess == names[i])
                {
                    //Displaying the index of the name in the list of names
                    Console.WriteLine("The index of that name in the list is: " + i);
                    validName = true;
                    break; //Code that stops the loop once a name is found
                }               
            }
            //Code to check if a name is not in the list
            if (!validName)
            {
                //Message displayed to the user when the name is not in the list
                Console.WriteLine("Sorry, that name is not found in the list.");
            }
            Console.ReadLine();

            //Console App Assignment Part 5
            //A list of strings that has at least two identical strings
            List<string> fruits = new List<string>()
            {
                "apple",
                "banana",
                "orange",
                "apple",
                "cherry",
                "mango",
                "banana"
            };
            //Asking the user to input text to search for in the list
            Console.WriteLine("\nPlease, enter a fruit to guess my favorite fruits:");
            //Taking the input, converting it to lowercase and assigning it to the variable guess1
            string guess1 = Console.ReadLine().ToLower();
            //A loop that iterates through the list
            bool validFruit = false;
            for (int j = 0; j < fruits.Count; j++)
            {
               if (guess1 == fruits[j])
               {
                    //Displaying the index of the fruit in the list of fruits
                    Console.WriteLine("The index of that fruit in the list is: " + j);
                    validFruit = true;
               }
            }
            //Code to check if a fruit is not in the list
            if (!validFruit)
            {
                //Message displayed to the user when the fruit is not in the list
                Console.WriteLine("Sorry, that fruit is not found in the list.");
            }
            Console.ReadLine();

            //Console App Assignment Part 6
            //A list of strings that has at least two identical strings
            List<string> letters = new List<string>() { "A", "B", "C", "D", "C", "E", "E" };
            List<string> checkedLetters = new List<string>();
            //A foreach loop that evaluates each item in the list
            foreach (string letter in letters)
            {
                //Checking the presence of the string
                if (checkedLetters.Contains(letter))
                {
                    //Displaying a message showing the string is a duplicate
                    Console.WriteLine(letter + " - " + "this item is a duplicate");
                }
                else 
                {
                    //Displaying a message showing the string is unique
                    Console.WriteLine(letter + " - " + "this item is unique");
                }
                checkedLetters.Add(letter);
            }
            Console.ReadLine();
                

        }
    }
}
