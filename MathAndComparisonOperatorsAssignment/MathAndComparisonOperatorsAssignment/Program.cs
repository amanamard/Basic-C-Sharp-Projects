using System;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print "Anonymous Income Comparison Program"
            Console.WriteLine("Anonymous Income Comparison Progam");

            //Print "Person 1"
            Console.WriteLine("Person 1");

            //Get Person 1 hourly rate
            Console.WriteLine("Hourly Rate?");
            int hourlyRatePerson1 = Convert.ToInt32(Console.ReadLine());
            
            //Get Person 1 hours worked per week
            Console.WriteLine("Hours worked per week?");
            int hoursWorkedPerson1 = Convert.ToInt32(Console.ReadLine());
            
            //Print "Person 2"
            Console.WriteLine("Person 2");

            //Get Person 2 hourly rate
            Console.WriteLine("Hourly Rate?");
            int hourlyRatePerson2 = Convert.ToInt32(Console.ReadLine());

            //Get Person 2 hours worked per week
            Console.WriteLine("Hours worked per week?");
            int hoursWorkedPerson2 = Convert.ToInt32(Console.ReadLine());

            //Print Person 1 annual salary
            Console.WriteLine("Annual salary of Person 1:");
            int annualSalaryPerson1 = hourlyRatePerson1 * hoursWorkedPerson1 * 52;
            Console.WriteLine(annualSalaryPerson1);

            //Print Person 2 annual salary
            Console.WriteLine("Annual salary of Person 2:");
            int annualSalaryPerson2 = hourlyRatePerson2 * hoursWorkedPerson2 * 52;
            Console.WriteLine(annualSalaryPerson2);

            //Comparison of annual salaries
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool trueOrFalse = annualSalaryPerson1 > annualSalaryPerson2;
            Console.WriteLine(trueOrFalse);

            Console.ReadLine();
        }
    }
}
