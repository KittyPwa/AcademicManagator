using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class PupilController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            PupilRepository ar = new PupilRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new PupilModel
                {
                    Id = acad.Id,
                    BirthdayDate = acad.BirthdayDate,
                    Classrooms = acad.Classrooms,
                    Classroom_Id = acad.Classroom_Id,
                    FirstName = acad.FirstName,
                    LastName = acad.LastName,
                    Levels = acad.Levels,
                    Level_Id = acad.Level_Id,
                    Results = acad.Results,
                    Sex = acad.Sex,
                    State = acad.State,
                    Tutors = acad.Tutors,
                    Tutor_Id = acad.Tutor_Id

                }).ToList<PupilModel>();
            return View("Index", result);
        }

        public ActionResult Create()
        {
            
            return View("Create", new PupilModel
            {
                Id = Guid.NewGuid()
            });
        }

    }
}