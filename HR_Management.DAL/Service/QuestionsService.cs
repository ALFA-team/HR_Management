using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class QuestionsService
    {
        private DataContext db = new DataContext();

        public IEnumerable<Questions> GetList()
        {
            var QuestionsList = db.Questions.ToList();
            return QuestionsList;
        }

        public Questions Get(Questions questions)
        {
            var quizz = db.Questions.Find(questions);
            if (quizz != null)
            {
                return quizz;
            }
            return null;

        }
        public Questions GetListByQuizId(int quizId)
        {
            var quizz = db.Questions.Where(a => a.QuizId == quizId).FirstOrDefault();
            if (quizz != null)
            {
                return quizz;
            }
            return null;
        }
        public Questions Get(int id)
        {
            var quizz = db.Questions.Where(a => a.id == id).FirstOrDefault();
            if (quizz != null)
            {
                return quizz;
            }
            return null;
        }
        public void Add(Questions questions)
        {
            if (questions != null)
            {
                db.Questions.Add(questions);
                db.SaveChanges();
            }
        }

        public void Delete(Questions questions)
        {
            if (questions != null)
            {
                db.Questions.Remove(questions);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var quizz = db.Questions.Where(a => a.id == id).FirstOrDefault();
            if (quizz != null)
            {
                db.Questions.Remove(quizz);
                db.SaveChanges();
            }

        }
        public void Edit(Questions questions)
        {
            if (questions != null)
            {
                db.Entry<Questions>(questions).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}

