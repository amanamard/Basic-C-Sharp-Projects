using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //A list of 10 employees with 2 employees having the first name "Joe"
            List<Employee> listOfEmployees = new List<Employee>() 
            {
                new Employee() { Id = 1, FirstName = "Peter", LastName = "Paul" },
                new Employee() { Id = 2, FirstName = "Jim", LastName = "Jones" },
                new Employee() { Id = 3, FirstName = "Clark", LastName = "Kent" },
                new Employee() { Id = 4, FirstName = "Joe", LastName = "Stark" },
                new Employee() { Id = 5, FirstName = "Jon", LastName = "Snow" },
                new Employee() { Id = 6, FirstName = "Bill", LastName = "Clinton" },
                new Employee() { Id = 7, FirstName = "Tim", LastName = "Duncan" },
                new Employee() { Id = 8, FirstName = "Mary", LastName = "Jane" },
                new Employee() { Id = 9, FirstName = "Joe", LastName = "Louis" },
                new Employee() { Id = 10, FirstName = "Billy", LastName = "Shaw"}
            };
            
            //New list of employees
            List<Employee> joes = new List<Employee>();
            //creating a new list of all employees with the first name “Joe” using a foreach loop
            foreach (Employee emp in listOfEmployees) 
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }
            //Printing the list of employees with the first name "Joe"            
            foreach (Employee emp in joes) 
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            //creating a new list of all employees with the first name “Joe” using a lambda expression
            List<Employee> joes2 = listOfEmployees.Where(x => x.FirstName == "Joe").ToList();
            //Printing the list of employees with the first name "Joe" 
            foreach (Employee emp in joes2)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            
            //Making a list of all employees with an Id number greater than 5 using a lambda expression
            List<Employee> employeesWithIdGreaterThanFive = listOfEmployees.Where(x => x.Id > 5).ToList();
            //Printing employessWithIdGreaterThanFive
            foreach(Employee emp in employeesWithIdGreaterThanFive)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            Console.ReadLine();
        }
    }
}
