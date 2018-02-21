using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcademicManagator.Models;

namespace AcademicManagator.Controllers
{
    public class AcademyController : Controller
    {
        // GET: Academy
        public ActionResult Index()
        {
            AcademyRepository ar = new AcademyRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new AcademyModel
                {
                    Id = acad.Id,
                    Name = acad.Name,
                    Establishments = (ICollection<Establishments>)acad.Establishments

                }).ToList<AcademyModel>();
            return View("Create", result);
        }
    }
}