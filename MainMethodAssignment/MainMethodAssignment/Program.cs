using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class MathMethod
            MathMethod mathMethod = new MathMethod();
            //Calling the first method with an integer argument and assigning the result to the variable x
            int x = mathMethod.MathOperation(5);
            //Displaying x on the screen
            Console.WriteLine(x);
            
            //Calling the second method with a decimal argument and assigning the result to the variable y
            int y = mathMethod.MathOperation(5.03230923m);
            //Displaying x on the screen
            Console.WriteLine(y);
           
            //Calling the third method with a string argument and assigning the result to the variable z
            int z = mathMethod.MathOperation("15");
            Console.WriteLine(z);
            Console.ReadLine();

        }
    }
}
