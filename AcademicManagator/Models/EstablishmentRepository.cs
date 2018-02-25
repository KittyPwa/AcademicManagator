using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class EstablishmentRepository
    {
        private AcademyEntities entities;

        public EstablishmentRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Establishments> All()
        {
            return entities.Establishments;
        }

        public Establishments GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Establishments s)
        {
            entities.Establishments.Add(s);
            Save();
        }

        public void Delete(Establishments s)
        {
            entities.Establishments.Remove(s);
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