using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "This is ";
            string string2 = "my string ";
            string string3 = "assignment.";

            //Concatenating three strings
            string result = string1 + string2 + string3;
            Console.WriteLine(result);
            
            //Converting a string to uppercase
            string uppercaseString = result.ToUpper();
            Console.WriteLine(uppercaseString);

            //Creating a StringBuilder
            StringBuilder sb = new StringBuilder();

            //Building a paragraph of text
            sb.Append("This is a paragraph of text built with a StringBuilder. ");
            sb.AppendLine("Sentences are built one at the time.");
            sb.AppendLine("Here, we can really see a StringBuilder in action...");

            Console.WriteLine(sb);
            
            Console.ReadLine();
        }
    }
}
