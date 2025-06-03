using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int i = 1;

            while (i < 5) //Continue to loop until i = 5
            {
                Console.WriteLine("Hello " + i);
                i++; //Add one to i each time
            }

            //Do while loop
            int j = 4;
            do
            {
                Console.WriteLine("Goodbye " + j);
                j--; //Subtract one to j each time
            }
            while (j > 0); //Continue to loop until j = 0

            Console.ReadLine();
        }
    }
}
