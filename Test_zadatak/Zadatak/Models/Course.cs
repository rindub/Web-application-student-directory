using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak.Models
{
    public class Course
    {
        
        public int CourseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProfessorName { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}