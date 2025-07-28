namespace FinalAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentEntities())
            {
                var student = new Student() { StudentName = "Peter Paul", DateOfBirth = new DateTime(2010, 07, 28) };

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
