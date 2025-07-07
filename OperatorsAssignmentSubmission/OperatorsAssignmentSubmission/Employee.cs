using System;

namespace OperatorsAssignmentSubmission
{
    //Employee class
    public class Employee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload the "==" operator
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        //Overload the "!=" operator
        public static bool operator!= (Employee employee1, Employee employee2)
        { 
            return !(employee1.Id == employee2.Id);
        }

    }
}
