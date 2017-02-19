using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.DAL.Entity
{
    public class DatabasetInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            QuestionType qt = new QuestionType() { Name = "List" };
            QuestionType qt1 = new QuestionType() { Name = "Text" };
            QuestionType qt2 = new QuestionType() { Name = "RadioButton" };
            QuestionType qt3 = new QuestionType() { Name = "CheckBox" };
            QuestionType qt4 = new QuestionType() { Name = "Dropdown" };
            QuestionType qt5 = new QuestionType() { Name = "Image" };
            context.QuestionType.AddRange(new List<QuestionType>() { qt, qt1, qt2, qt3, qt4, qt5 });
            context.SaveChanges();
        }
    }
}
