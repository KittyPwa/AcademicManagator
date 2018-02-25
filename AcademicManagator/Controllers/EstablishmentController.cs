using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class EstablishmentController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            EstablishmentRepository ar = new EstablishmentRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new EstablishmentModel
                {
                    Id = acad.Id,
                    Name = acad.Name,
                    Academies = acad.Academies, 
                    Academie_Id = acad.Academie_Id,
                    Address = acad.Address,
                    Classrooms = acad.Classrooms,
                    PostCode = acad.PostCode,
                    Town = acad.Town,
                    Users = acad.Users,
                    User_Id = acad.User_Id


                }).ToList<EstablishmentModel>();
            return View("Index", result);
        }

    }
}