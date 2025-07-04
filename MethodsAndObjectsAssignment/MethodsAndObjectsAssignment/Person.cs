using System;

namespace MethodsAndObjectsAssignment
{
    //Creating class Person
    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //A void method
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
