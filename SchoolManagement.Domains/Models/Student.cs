using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domains.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int RollNo { get; set; }
        public int GradeId { get; set; }
        public required Grade Grade { get; set; }
    }
}
