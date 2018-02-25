using AcademicManagator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademicManagator.Controllers
{
    public class UserController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            UserRepository ar = new UserRepository(new AcademyEntities());
            var result = ar.All()
                .Select(acad => new UserModel
                {
                    Id = acad.Id,
                    Classrooms = acad.Classrooms,
                    Establishments = acad.Establishments,
                    Evaluations = acad.Evaluations,
                    FirstName = acad.FirstName,
                    LastName = acad.LastName,
                    Mail = acad.Mail,
                    Password = acad.Password,
                    UserName = acad.UserName      


                }).ToList<UserModel>();
            return View("Index", result);
        }

    }
}