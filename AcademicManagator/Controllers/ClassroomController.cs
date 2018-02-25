using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class ClassroomController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            ClassroomRepository ar = new ClassroomRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new ClassroomModel
                {
                    Id = acad.Id,
                    Establishment_Id = acad.Establishment_Id,
                    Evaluations = acad.Evaluations,
                    Pupils = (ICollection<Pupils>)acad.Pupils,
                    Title = acad.Title,
                    Users = acad.Users,
                    User_Id = acad.User_Id,
                    Years = acad.Years,
                    Year_Id = acad.Year_Id


                }).ToList<ClassroomModel>();
            return View("Index", result);
        }

    }
}