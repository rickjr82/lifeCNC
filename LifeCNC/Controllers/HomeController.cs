using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeCNC.Models;
using LifeCNC.ViewModels;
using System.Web.Script.Serialization;

namespace LifeCNC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var context = new survey_dbContext();
            var model = new cmSurveyList(context.SurveyQuestions);
            var result = View(model);
            return result;
        }
        public ActionResult SaveQuestion(string data)
        {
            var question = new JavaScriptSerializer().Deserialize<SurveyQuestion>(data);
            var context = new survey_dbContext();
            var questionToDelete = context.SurveyQuestions.Find(question.Id);
            if (questionToDelete == null)
            {
                context.SurveyQuestions.Add(question);
            }
            else
            {
                questionToDelete.Question = question.Question; 
            }
            context.SaveChanges();
            var result = Json(question, JsonRequestBehavior.AllowGet);
            return result;

        }
        public ActionResult DeleteQuestion(string data)
        {
            var question = new JavaScriptSerializer().Deserialize<SurveyQuestion>(data);
            
            var context = new survey_dbContext();
            var questionToDelete = context.SurveyQuestions.Find(question.Id);
            context.SurveyQuestions.Remove(questionToDelete);
            context.SaveChanges();
            var result = Json(question, JsonRequestBehavior.AllowGet);
            return result;

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
