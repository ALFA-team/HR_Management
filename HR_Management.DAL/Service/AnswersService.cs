using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class AnswersService
    {
        private DataContext db = new DataContext();

        public IEnumerable<Answers> GetList()
        {
            var answersList = db.Answers.ToList();
            return answersList;
        }

        public Answers Get(Answers answers)
        {
            var answer = db.Answers.Find(answers);
            if (answer != null)
            {
                return answer;
            }
            return null;

        }
        public Answers GetbyQuestId(int questId)
        {
            var answer = db.Answers.Where(a => a.QuestId == questId).FirstOrDefault();
            if (answer != null)
            {
                return answer;
            }
            return null;
        }
        public Answers Get(int id)
        {
            var answer = db.Answers.Where(a => a.id == id).FirstOrDefault();
            if (answer != null)
            {
                return answer;
            }
            return null;
        }
        public void Add(Answers answer)
        {
            if (answer != null)
            {
                db.Answers.Add(answer);
                db.SaveChanges();
            }
        }

        public void Delete(Answers answer)
        {
            if (answer != null)
            {
                db.Answers.Remove(answer);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var answer = db.Answers.Where(a => a.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.Answers.Remove(answer);
                db.SaveChanges();
            }

        }
        public void Edit(Answers answer)
        {
            if (answer != null)
            {
                db.Entry<Answers>(answer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
