using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing "Academy of Learning Career College"
            Console.WriteLine("Academy of Learning Career College");
            
            //Printing "Student Daily Report"
            Console.WriteLine("Student Daily Report");
            
            //Asking questions to the student and saving the answers
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
           
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //Printing a message ending the questions
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
