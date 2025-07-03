using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathMethod2
    {
        //Creating a method that takes two integers as parameters
        //Making one of them optional by providing a default value
        public int MathOperation2(int a, int b = 0)
        {
            //Performing addition on integers and returning the result
            return a + b;
        }
    }
}
