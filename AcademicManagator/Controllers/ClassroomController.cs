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
            Models.ClassroomRepository sr = new Models.ClassroomRepository(new Models.AcademyEntities());
                 var result = sr.All()
                     .Select(sim => new Models.ClassroomModel
                     {


                     }).ToList<Models.ClassroomModel>();
                 return View("Index", result);
          /*  var result = new List<Models.ClassroomModel>();
            result.Add(new Models.ClassroomModel());
            return View("Index", result);*/
        }
    }
}