using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FacultyManagement.Models;

namespace FacultyManagement.Controllers
{
    public class FacultyController : Controller
    {
        private IFacultyRepository repository;



        public FacultyController(IFacultyRepository repo)
        {
            repository = repo;
        }


        public ViewResult ViewFaculty()
        {

            return View(repository.Faculty
                    .OrderBy(p => p.fId));
        }

        public ViewResult EditFaculty(int fid) =>
            View(repository.Faculty
                .FirstOrDefault(p => p.fId == fid));



        [HttpPost]
        public IActionResult UpdateFaculty(FacultyResponse facultyResponse)
        {
            ViewBag.Facultyviewmsg = "List of faculty we have";
            // Repository.AddFResponse(facultyResponse);
            repository.SaveFaculty(facultyResponse);

            ViewBag.Thanksmsg = "Faculty Details Successfully Updated, go to View page to view details.";
            return View("Thankyou", facultyResponse);
        }


        public RedirectToActionResult DeleteFaculty(int fid)
        {
            FacultyResponse deleteFaculty = repository.DeleteFaculty(fid);
            if (deleteFaculty != null)
            {
                TempData["message"] = $"{deleteFaculty.fName} has been deleted!";
            }
            return RedirectToAction("ViewFaculty");
        }


        [HttpPost]
        public IActionResult AddFaculty(FacultyResponse facultyResponse)
        {
            ViewBag.Facultyviewmsg = "List of faculty we have";
            // Repository.AddFResponse(facultyResponse);
            repository.SaveFaculty(facultyResponse);

            ViewBag.Thanksmsg = "Faculty Details Successfully Saved, go to View page to view details.";
            return View("Thankyou", facultyResponse);
        }









        public ViewResult FacultyFeedback()
        {
            ViewData["Faculty"] = repository.Faculty
                    .OrderBy(p => p.fId);
            return View();
        }

        [HttpPost]
        public IActionResult FacultyFeedback(FeedbackResponse feed)
        {
            repository.SaveFeedback(feed);
            ViewBag.Thanksmsg = "Feedback Details Successfully Saved, go to View page to view details.";
            return View("Thankyou", feed);
        }














        public ViewResult AddFaculty()
        {
            ViewBag.Facultymsg = "Enter Details of Faculty";
            return View("AddFaculty");
        }



        public ViewResult ViewAssignedFaculty()
        {
            return View(Repository.CAFResponses.Where(r => r.courseName == r.courseName));
        }
        [HttpPost]
        public ViewResult AssignFaculty(CourseAndFaculty cAf)
        {
            Repository.AddCAFResponse(cAf);
            ViewBag.Thanksmsg = "Faculty Assigned Successfully , go to View page to view details.";
            return View("Thankyou", cAf);
        }

        public ViewResult AssignFaculty()
        {
            ViewData["Course"] = Repository.CResponses.Where(r => r.cId == r.cId);
            ViewData["Faculty"] = repository.Faculty
                    .OrderBy(p => p.fId);
            return View();



        }


    }






}
