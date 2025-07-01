using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class MathOperation
    {
        //Three methods that take one integer parameter and return an integer
        public static int Add(int x)
        {
            int sum = x + 5;
            return sum;
        }
        
        public static int Subtract(int y)
        {
            int diff = y - 5;
            return diff;
        }

        public static int Multiply(int z)
        {
            int product = z * 5;
            return product;
        }                
    }
}
