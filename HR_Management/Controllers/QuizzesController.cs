using System;
using System.Collections.Generic;
using System.Web.Mvc;
using HR_Management.Models;

namespace HR_Management.Controllers
{
    public class QuizzesController : Controller
    {
        // GET: Quizzes
        public ActionResult Index()
        {
            var demoQuizzesList = new List<QuizzesModel>()
            {
                new QuizzesModel()
                {
                    Name = "test 1",
                    Description = "test 1,Description",
                    LastAccessDate = DateTime.Now,
                    Result = "11/15"
                },

                new QuizzesModel()
                {
                    Name = "test 2",
                    Description = "test 2,Description",
                    LastAccessDate = DateTime.Now,
                    Result = "10/75"
                },

                new QuizzesModel()
                {
                    Name = "test 3",
                    Description = "test 3,Description",
                    LastAccessDate = DateTime.Now,
                    Result = "locked"
                }
            };



            return View(demoQuizzesList);
        }

        // GET: Quizzes/Start/5
        public ActionResult Start(int id)
        {            
            AnswersModel ans1 = new AnswersModel() {AnswersId = 1, Text="ONLI 2" };
            AnswersModel ans2 = new AnswersModel() { AnswersId = 2, Text = "ONLI 4" };
            AnswersModel ans3 = new AnswersModel() { AnswersId = 3, Text = "ONLI 6" };
            AnswersModel ans4 = new AnswersModel() { AnswersId = 4, Text = "ONLI 8" };
            List<AnswersModel> anslist1 = new List<AnswersModel>() { ans1, ans2, ans3, ans4};
            QuestionsModel quest1 = new QuestionsModel() { QuestionsId = 1, Text = " 2 + 2 = ", Answers = anslist1 };

            AnswersModel ans5 = new AnswersModel() { AnswersId = 5, Text = "ONLI 4" };
            AnswersModel ans6 = new AnswersModel() { AnswersId = 6, Text = "ONLI 6" };
            AnswersModel ans7 = new AnswersModel() { AnswersId = 7, Text = "ONLI 8" };
            AnswersModel ans8 = new AnswersModel() { AnswersId = 8, Text = "ONLI 12" };
            List<AnswersModel> anslist2 = new List<AnswersModel>() { ans5, ans6, ans7, ans8 };
            QuestionsModel quest2 = new QuestionsModel() { QuestionsId = 1, Text = " 2 + 2 * 2 = ", Answers = anslist2 };

            List<QuestionsModel> Questions = new List<QuestionsModel>() { quest1, quest2};
            
            return View(new QuizViewModel().Question = Questions);
        }

        [HttpPost]
        public ActionResult Start(int[] AnsId)
        {
            int[] curentAnswer = new int[] { 2, 6};
            if (curentAnswer[0] == AnsId[0] & curentAnswer[1] == AnsId[1])
            {
                return PartialView("Result", "You a Genius");
            }

            return PartialView("Result", "Try again");
        }

        //// GET: Quizzes/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Quizzes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Quizzes/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Quizzes/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Quizzes/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Quizzes/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Quizzes/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
