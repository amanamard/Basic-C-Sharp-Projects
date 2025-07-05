using System;

namespace AbstractClassAssignment
{
    //Creating abstract class Person
    public abstract class Person
    {
        //Properties
        public string firstName {  get; set; }
        public string lastName { get; set; }

        //Abstract method SayName()
        public abstract void SayName();
    }
}
