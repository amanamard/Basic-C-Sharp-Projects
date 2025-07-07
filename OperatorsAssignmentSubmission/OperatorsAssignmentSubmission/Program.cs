using System;

namespace OperatorsAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating two objects of the Employee class and assigning values to their properties
            Employee employee1 = new Employee() { Id = 456123, FirstName = "Peter", LastName = "Paul" };
            Employee employee2 = new Employee() { Id = 456123, FirstName = "Jim", LastName = "Jones"  };

            //Comparing the two Employee objects
            bool result = employee1 == employee2;
            //Displaying the result
            Console.WriteLine("Employee1 and Employee2 are equal? " + result);
            Console.ReadLine();

        }
    }
}
