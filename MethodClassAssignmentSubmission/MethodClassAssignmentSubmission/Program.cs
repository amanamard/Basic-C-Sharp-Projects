using System;


namespace MethodClassAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class MathMethod3
            MathMethod3 method = new MathMethod3();
            //Calling the method in the class, passing in two integers
            method.MathOperation3(7, 9);
            //Calling the method in the class, specifying the parameters by name
            method.MathOperation3(a: 7, b: 9);
            Console.ReadLine();
        }
    }
}
