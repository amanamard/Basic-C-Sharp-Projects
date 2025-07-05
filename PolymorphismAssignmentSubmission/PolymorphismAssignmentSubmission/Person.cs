using System;

namespace PolymorphismAssignmentSubmission
{
    //Abstract class Person
    public abstract class Person
    {
        //Properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Abstract method SayName()
        public abstract void SayName();
    }
}
