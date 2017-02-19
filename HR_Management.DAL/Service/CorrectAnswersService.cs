using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class CorrectAnswersService
    {
        private DataContext db = new DataContext();

        public IEnumerable<CorrectAnswers> GetList()
        {
            var answersList = db.CorrectAnswers.ToList();
            return answersList;
        }
        public IEnumerable<CorrectAnswers> GetQuestionList(int questionId)
        {
            var answersList = db.CorrectAnswers.Where(q => q.QuestionId == questionId).ToList();
            return answersList;
        }
        public IEnumerable<CorrectAnswers> GetAnswerList(int answersId)
        {
            var answersList = db.CorrectAnswers.Where(q => q.AnswersId == answersId).ToList();
            return answersList;
        }

        public IEnumerable<CorrectAnswers> Get(int questionId, int answersId)
        {
            var answersList = db.CorrectAnswers.Where(q => q.AnswersId == answersId && q.AnswersId == answersId).ToList();
            return answersList;
        }

        public void Add(int questionId, int answersId)
        {
            CorrectAnswers answer = new CorrectAnswers() { AnswersId = answersId, QuestionId = questionId };
            if (answer != null)
            {
                db.CorrectAnswers.Add(answer);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            CorrectAnswers answer = db.CorrectAnswers.Where(q => q.id == id).FirstOrDefault();

            if (answer != null)
            {
                db.CorrectAnswers.Remove(answer);
                db.SaveChanges();
            }
        }
    }
}
