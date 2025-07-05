using System;

namespace PolymorphismAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an Employee object
            Employee employee = new Employee() { FirstName = "Peter", LastName = "Paul", Id = 987123};
            //Calling the method SayName()
            employee.SayName();
            
            //Using polymorphism to create an object of type IQuittable
            IQuittable quittable = new Employee();
            //Calling the Quit() method
            quittable.Quit(employee);
            Console.ReadLine();
        }
    }
}
