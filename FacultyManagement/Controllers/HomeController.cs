using FacultyManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyManagement.Controllers
{
    public class HomeController : Controller
    {
        private IFacultyRepository repository;



        public HomeController(IFacultyRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            Repository.cResponses.Add(new CourseResponse
            {
                cId = 229,
                cName = "Web",
                cCredit = 4
            });

            Repository.cResponses.Add(new CourseResponse
            {
                cId = 304,
                cName = "Android",
                cCredit = 3
            });

            Repository.cResponses.Add(new CourseResponse
            {
                cId = 311,
                cName = "Testing",
                cCredit = 4
            });

            Repository.cResponses.Add(new CourseResponse
            {
                cId = 254,
                cName = "DataStructure",
                cCredit = 3
            });


            return View("Home");

        }
        public ViewResult Home()
        {
            return View("Home");
        }

        public ViewResult Feedback()
        {
            ViewData["FeedbackData"] = (repository.Feedback.Where(r => r.fId == r.fId));


            return View();
        }

        public ViewResult FilterFeedback(string rating)
        {
            ViewData["FeedbackData"] = (repository.Feedback.Where(r => r.feedback == rating));


            return View();
        }












    }
}
