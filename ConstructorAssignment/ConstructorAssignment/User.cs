using System;

namespace ConstructorAssignment
{
    public class User
    {
        //Chaining of two constructors
        public User(string name) : this(name, 46) 
        {
        }
        public User(string name, int age) 
        {
            this.userName = name;
            this.userAge = age;
        }
        //Properties
        public int userAge { get; set; }
        public string userName { get; set; }
    }
}
