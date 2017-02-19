using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HR_Management.DAL.Entity
{
    public class Quizzes
    {    
        [Key]
        public int id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public IEnumerable<Questions> Questions { get; set; }

        public Quizzes()
        {
            Questions = new List<Questions>();
        }
    }
}