using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class QuestionType
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

    }
}
