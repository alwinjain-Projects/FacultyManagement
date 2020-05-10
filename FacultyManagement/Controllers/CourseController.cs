using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacultyManagement.Models;

namespace FacultyManagement.Controllers
{
    public class CourseController : Controller
    {
        private IFacultyRepository repository;



        public CourseController(IFacultyRepository repo)
        {
            repository = repo;
        }
        public ViewResult AddCourse()
        {
            ViewBag.Coursemsg = "Enter Details of Courses";
            return View("AddCourse");
        }
        public ViewResult ViewCourse()
        {
            ViewBag.Courseviewmsg = "List of course we have";
            
            return View(Repository.CResponses.Where(r => r.cId == r.cId));
        }

        [HttpPost]
        public ViewResult AddCourse(CourseResponse courseResponse)
        {
            Repository.AddCResponse(courseResponse);
            ViewBag.Thanksmsg = "Course Details Successfully Saved, go to View page to view details.";

            return View("Thankyou", courseResponse);
        }



        public ViewResult CourseFeedback()
        {
            ViewData["Course"] = Repository.CResponses.Where(r => r.cId == r.cId);
            ViewData["Faculty"] = repository.Faculty
              .OrderBy(p => p.fId);
            return View();
        }

        [HttpPost]
        public IActionResult CourseFeedback(FeedbackResponse feed)
        {
            ViewBag.Facultyviewmsg = "List of faculty we have";
            // Repository.AddFResponse(facultyResponse);
            repository.SaveFeedback(feed);

            ViewBag.Thanksmsg = "Feedback Details Successfully Saved, go to View page to view details.";
            return View("Thankyou", feed);
        }
    }
}
