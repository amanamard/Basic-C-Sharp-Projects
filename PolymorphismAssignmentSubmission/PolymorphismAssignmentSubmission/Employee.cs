using System;

namespace PolymorphismAssignmentSubmission
{
    //A class Employee that inherited from class Person and interface IQuittable
    public class Employee : Person, IQuittable
    {
        //Property
        public int Id { get; set; }

        //Implementing the SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + "\nId: " + Id);   
        }

        //Implementing the Quit() method
        public void Quit(Employee employee) 
        {
            Console.WriteLine("Status: Has quit the job." );
        }
    }
}
