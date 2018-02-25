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
            return View("Index",result);
        }

        public ActionResult Create()
        {
           
            ViewData["terms"] = getEstablishments();
            return View("Create",new AcademyModel
            {
                Id = Guid.NewGuid()
            });
        }

        [HttpPost]
        public ActionResult Create(AcademyModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["terms"] = getEstablishments();
                return View(model);
            }
            AcademyRepository sr = new AcademyRepository(new AcademyEntities());
            sr.Add(new Academies
            {
                Id = model.Id,
                Name = model.Name,
                Establishments = (ICollection<Establishments>)model.Establishments.AsEnumerable()
            });
        
            return View("Details", model); ;
        }

        private List<Establishments> getEstablishments()
        {
            AcademyRepository ar = new AcademyRepository(new AcademyEntities());
            List<Establishments> establishment = new List<Establishments>();
            var result = ar.All()
                .Select(acad => new AcademyModel
                {
                    Id = acad.Id,
                    Name = acad.Name,
                    Establishments = (ICollection<Establishments>)acad.Establishments

                }).ToList<AcademyModel>();
            foreach (var item in result)
            {
                foreach (var estab in item.Establishments)
                    establishment.Add(estab);
            }
            return establishment;
        }
    }
}