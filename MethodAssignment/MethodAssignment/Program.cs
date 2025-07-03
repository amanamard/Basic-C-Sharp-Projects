using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating MathMethod2 class
            MathMethod2 method = new MathMethod2();
            //Asking the user to provide the first argument
            Console.WriteLine("Enter an integer:");
            //Taking the input, converting it into integer and assigning it to variable num1
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Asking the user to provide the second argument or to press enter
            Console.WriteLine("Enter a second integer or just press enter:");
                        
            try
            {
                //Taking the input, converting it into integer and assigning it to variable num2
                int num2 = Convert.ToInt32(Console.ReadLine());
                //Calling method with two parameters if two arguments are provided
                int result = method.MathOperation2(num1, num2);
                Console.WriteLine(num1 + " + " + num2 + " = " + result);

            }
            catch
            {
                //Calling method with one parameter if only one argument is provided
                int result = method.MathOperation2(num1);
                Console.WriteLine(num1 + " + Default 0 = " + result);
            }
            Console.ReadLine();
        }
    }
}
