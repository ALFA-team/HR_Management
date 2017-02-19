using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class ResultQuizService
    {
      private  DataContext db = new DataContext();

        public IEnumerable<ResultQuiz> GetList()
        {
            var resultQuizList = db.ResultQuiz.ToList();
            return resultQuizList;
        }

        public ResultQuiz Get(ResultQuiz resultQuizList)
        {
            var resultQuiz = db.ResultQuiz.Find(resultQuizList);
            if (resultQuiz != null)
            {
                return resultQuiz;
            }
            return null;

        }
        public ResultQuiz GetForQuiz(int quizId)
        {
            var resultQuiz = db.ResultQuiz.Where(a => a.id == quizId).FirstOrDefault();
            if (resultQuiz != null)
            {
                return resultQuiz;
            }
            return null;
        }
        public ResultQuiz GetForUser(int userId)
        {
            var resultQuiz = db.ResultQuiz.Where(a => a.id == userId).FirstOrDefault();
            if (resultQuiz != null)
            {
                return resultQuiz;
            }
            return null;
        }
        public ResultQuiz Get(int id)
        {
            var resultQuiz = db.ResultQuiz.Where(a => a.id == id).FirstOrDefault();
            if (resultQuiz != null)
            {
                return resultQuiz;
            }
            return null;
        }
        public void Add(ResultQuiz resultQuiz)
        {
            if (resultQuiz != null)
            {
                db.ResultQuiz.Add(resultQuiz);
                db.SaveChanges();
            }
        }

        public void Delete(ResultQuiz resultQuiz)
        {
            if (resultQuiz != null)
            {
                db.ResultQuiz.Remove(resultQuiz);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var resultQuiz = db.ResultQuiz.Where(a => a.id == id).FirstOrDefault();
            if (resultQuiz != null)
            {
                db.ResultQuiz.Remove(resultQuiz);
                db.SaveChanges();
            }
        }
        public void Edit(ResultQuiz resultQuiz)
        {
            if (resultQuiz != null)
            {
                db.Entry<ResultQuiz>(resultQuiz).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
