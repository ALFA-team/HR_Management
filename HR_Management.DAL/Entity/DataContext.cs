using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("QuizzesConnection")
        {
            Database.SetInitializer<DataContext>(new DatabasetInitializer());
        }

        public DbSet<Quizzes> Quizzes { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }
        public DbSet<CorrectAnswers> CorrectAnswers { get; set; }
        public DbSet<ResultQuiz> ResultQuiz { get; set; }

    }
}
