using System.Collections.Generic;

namespace EfWorkshop.DataAccess.Models
{
    internal class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
    }
}
