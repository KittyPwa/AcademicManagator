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
            ClassroomRepository sr = new ClassroomRepository(new Entities());
            var result = sr.All()
                .Select(sim => new Models.ClassroomModel
                {


                }).ToList<Models.ClassroomModel>();
            return View("Index", result);
        }
    }
}