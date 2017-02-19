using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HR_Management.DAL.Entity
{
    public class Questions
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Питання")]
        public string Text { get; set; }


        [Required(ErrorMessage = "Выбирите имя теста")]
        [Display(Name = "Имя теста")]
        public int QuizId { get; set; }

        public Quizzes Quizzes { get; set; }

        [Required(ErrorMessage = "Выбирите тип вопроса")]
        [Display(Name = "Тип вопроса")]
        public int QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; }

        //public IEnumerable<Answers> Answers { get; set; }

        //public Questions()
        //{
        //    Answers = new List<Answers>();
        //}


    }
}