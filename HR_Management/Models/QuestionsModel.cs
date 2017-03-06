using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Management.Models
{
    public class QuestionsModel
    {
        public int QuestionsId { get; set; }
        public string Text { get; set; }
        public IEnumerable<AnswersModel> Answers { get; set; }        
    }
}