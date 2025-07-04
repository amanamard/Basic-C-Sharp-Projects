using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating and initializing an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Calling the superclass SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
