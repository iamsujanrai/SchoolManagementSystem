using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domains.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Qualification { get; set; } = string.Empty;
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
