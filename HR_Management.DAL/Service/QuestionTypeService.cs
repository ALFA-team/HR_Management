using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class QuestionTypeService
    {
        private DataContext db = new DataContext();

        public IEnumerable<QuestionType> GetList()
        {
            var questionTypeList = db.QuestionType.ToList();
            return questionTypeList;
        }

        public QuestionType Get(QuestionType questionType)
        {
            var questionT = db.QuestionType.Find(questionType);
            if (questionT != null)
            {
                return questionT;
            }
            return null;

        }
        public QuestionType Get(string typeName)
        {
            var questionT = db.QuestionType.Where(a => a.Name == typeName).FirstOrDefault();
            if (questionT != null)
            {
                return questionT;
            }
            return null;
        }
        public QuestionType Get(int id)
        {
            var questionT = db.QuestionType.Where(a => a.id == id).FirstOrDefault();
            if (questionT != null)
            {
                return questionT;
            }
            return null;
        }
        public void Add(QuestionType questionType)
        {
            if (questionType != null)
            {
                db.QuestionType.Add(questionType);
                db.SaveChanges();
            }
        }

        public void Delete(QuestionType questionType)
        {
            if (questionType != null)
            {
                db.QuestionType.Remove(questionType);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var questionType = db.QuestionType.Where(a => a.id == id).FirstOrDefault();
            if (questionType != null)
            {
                db.QuestionType.Remove(questionType);
                db.SaveChanges();
            }

        }
        public void Edit(QuestionType questionType)
        {
            if (questionType != null)
            {
                db.Entry<QuestionType>(questionType).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
