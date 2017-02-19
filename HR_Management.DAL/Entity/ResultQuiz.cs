using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class ResultQuiz
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Имя")]
        public string Result { get; set; }
        public DateTime Date { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
    }
}
