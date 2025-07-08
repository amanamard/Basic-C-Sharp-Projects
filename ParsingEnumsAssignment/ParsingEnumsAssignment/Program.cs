using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Enum for the days of the week
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            //Prompt the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");
            //Taking the input and assigning it to the variable currentDayInput
            string currentDayInput = Console.ReadLine();
            bool validDay = false;
            while (!validDay)
            {
                try
                {
                    //Assign the value to a variable of that enum data type you just created
                    DaysOfWeek dayOfWeek = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDayInput, true);
                    Console.WriteLine("Have a wonderful " + dayOfWeek);
                    validDay = true;
                }
                catch
                {
                    //Message for invalid day input
                    Console.WriteLine("Please enter an actual day of the week.");
                    currentDayInput = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}