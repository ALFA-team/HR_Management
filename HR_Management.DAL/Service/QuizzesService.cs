using HR_Management.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Service
{
    public class QuizzesService
    {
        private DataContext db = new DataContext();

        public IEnumerable<Quizzes> GetList()
        { 
            var quizzesList = db.Quizzes.ToList();
            return quizzesList;
        }

        public Quizzes Get(Quizzes quizzes)
        {
            var quizz = db.Quizzes.Find(quizzes);
            if (quizz != null)
            {
                return quizz;
            }
            return null;

        }
        public Quizzes Get(string quizzesName)
        {
            var quizz = db.Quizzes.Where(a => a.Name == quizzesName).FirstOrDefault();
            if (quizz != null)
            {
                return quizz;
            }
            return null;
        }
        public Quizzes Get(int id)
        {
            var quizz = db.Quizzes.Where(a => a.id == id).FirstOrDefault();
            if (quizz != null)
            {
                return quizz;
            }
            return null;
        }
        public void Add(Quizzes quizzes)
        {
            if (quizzes != null)
            {
                db.Quizzes.Add(quizzes);
                db.SaveChanges();
            }
        }

        public void Delete(Quizzes quizzes)
        {
            if (quizzes != null)
            {
                db.Quizzes.Remove(quizzes);
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var quizz = db.Quizzes.Where(a => a.id == id).FirstOrDefault();
            if (quizz != null)
            {
                db.Quizzes.Remove(quizz);
                db.SaveChanges();
            }

        }
        public void Edit(Quizzes quizz)
        {          
            if (quizz != null)
            {
                db.Entry<Quizzes>(quizz).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
       
    }
}
