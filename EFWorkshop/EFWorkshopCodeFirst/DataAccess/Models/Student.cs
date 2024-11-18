namespace EfWorkshop.DataAccess.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double AverageGrade { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

    }
}
