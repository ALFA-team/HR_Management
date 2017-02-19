using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class CorrectAnswers
    {
        [Key]
        public int id { get; set; }
        public int QuestionId { get; set; }
        public int AnswersId { get; set; }
    }
}
