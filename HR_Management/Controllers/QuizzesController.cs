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
            throw new NotImplementedException();
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
