using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a const variable
            const string assignmentName = "Constructor Assignment";
            Console.WriteLine("Welcome to the {0}.\n", assignmentName);
            //Creating a variable using the keyword "var"
            var newUser = new User("Ben");
            Console.WriteLine("{0} is {1} years old.", newUser.userName, newUser.userAge);
            Console.ReadLine();
        }
    }
}
