using System;

namespace ClassMethodAssignment
{
    //Creating IntegerMethod class
    class IntegerMethod
    {
        //A void method that outputs an integer
        public void IntegerOperation(int a)
        {
            int b = a / 2;
            Console.WriteLine(a + " / 2 = " + b);
        }

        //An overload method with output parameters
        public int IntegerOperation(int a, out int b)
        {
            b = 0;
            int c = a * 2;
            b++;
            return c;
        }
    }
}
