using System;

namespace AbstractClassAssignment
{
    //Creating class Employee that inherited from class Person
    public class Employee : Person
    {
        public int Id { get; set; }

        //Implementing the SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
