using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domains.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Grade Grade { get; set; }
    }
}
