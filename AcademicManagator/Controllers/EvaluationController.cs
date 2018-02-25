using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class EvaluationController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            EvaluationRepository ar = new EvaluationRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new EvaluationModel
                {
                    Id = acad.Id,
                    Classrooms = acad.Classrooms,
                    Classroom_Id = acad.Classroom_Id,
                    Date = acad.Date,
                    Periods = acad.Periods,
                    Period_Id = acad.Period_Id,
                    Results = acad.Results,
                    TotalPoint = acad.TotalPoint,
                    Users = acad.Users,
                    User_Id = acad.User_Id


                }).ToList<EvaluationModel>();
            return View("Index", result);
        }

        public ActionResult Create()
        {
            
            return View("Create", new EvaluationModel
            {
                Id = Guid.NewGuid()
            });
        }

    }
}