using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class TutorRepository
    {
        private AcademyEntities entities;

        public TutorRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Tutors> All()
        {
            return entities.Tutors;
        }

        public Tutors GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Tutors s)
        {
            entities.Tutors.Add(s);
            Save();
        }

        public void Delete(Tutors s)
        {
            entities.Tutors.Remove(s);
            Save();
        }

        public void Save()
        {
            try
            {
                entities.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }

    }
}