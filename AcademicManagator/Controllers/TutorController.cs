using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class TutorController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            TutorRepository ar = new TutorRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new TutorModel
                {
                    Id = acad.Id,
                    Address = acad.Address,
                    Comment = acad.Comment,
                    FirstName = acad.FirstName,
                    LastName = acad.LastName,
                    Mail = acad.Mail,
                    PostCode = acad.PostCode,
                    Pupils = acad.Pupils,
                    Tel = acad.Tel,
                    Town = acad.Town

                }).ToList<TutorModel>();
            return View("Index", result);
        }

        public ActionResult Create()
        {
            
            return View("Create", new TutorModel
            {
                Id = Guid.NewGuid()
            });
        }

    }
}