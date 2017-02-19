using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class Answers
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Тест ответа")]
        public string Text { get; set; }

        [Display(Name = "Вопрос")]
        public int QuestId { get; set; }

        public Questions Questions { get; set; }
    }
}
