using AutoTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoTestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            QaQuizViewModel
                qa1 = new QaQuizViewModel()
                {
                    Question = "בן כמה אתה",
                    Answers = new List<string>() { "54", "3", "2" },
                    CorrectAnswerIndex = 0
                },
                qa2 = new QaQuizViewModel()
                {
                    Question = "איפה אתה גר",
                    Answers = new List<string>() { "ירושלים", "חיפה", "תל אביב" },
                    CorrectAnswerIndex = 1
                },
                qa3 = new QaQuizViewModel()
                {
                    Question = "כמה ילדים יש לך",
                    Answers = new List<string>() { "1", "3", "2" },
                    CorrectAnswerIndex = 2
                };
            IList<QaQuizViewModel> l = new List<QaQuizViewModel>() { qa1, qa2, qa3 };

            return View(l);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}