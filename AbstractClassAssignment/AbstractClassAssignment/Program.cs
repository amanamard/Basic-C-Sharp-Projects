using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an Employee object
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //Calling the method SayName()
            employee.SayName();
            Console.ReadLine();

        }
    }
}
