using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domains.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Student>? Students { get; set; }
    }
}
