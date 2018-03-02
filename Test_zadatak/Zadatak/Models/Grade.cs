using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak.Models
{
    public class Grade
    {
       
        public int GradeID { get; set; }

        [Range(1, 5,
            ErrorMessage = "Grade must be 1,2,3,4 or 5")]
        public int? GradeForStudent { get; set; }
        public DateTime Date { get; set; }
        
        public string Comment { get; set; }
        
       
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}