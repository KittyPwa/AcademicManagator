using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class PupilRepository
    {
        private AcademyEntities entities;

        public PupilRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Pupils> All()
        {
            return entities.Pupils;
        }

        public Pupils GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Pupils s)
        {
            entities.Pupils.Add(s);
            Save();
        }

        public void Delete(Pupils s)
        {
            entities.Pupils.Remove(s);
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