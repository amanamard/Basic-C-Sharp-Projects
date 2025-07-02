using System;

namespace MainMethodAssignment
{
    class MathMethod
    {
        //A method that takes in an integer, add 7 to it and return the answer as an integer
        public int MathOperation(int a)
        {
            return a + 7;
        }

       //A method that takes in a decimal, multiply it by 7 and return the answer as an integer
        public int MathOperation(decimal a) 
        {
            return (int)a * 9;
        }

        //A method that takes in a string, convert it to an integer and return the remainder as an integer
        public int MathOperation(string a) 
        {
            int num = Convert.ToInt32(a);
            return num % 2;
        }
    }
}
