using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class EvaluationRepository
    {
        private AcademyEntities entities;

        public EvaluationRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Evaluations> All()
        {
            return entities.Evaluations;
        }

        public Evaluations GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Evaluations s)
        {
            entities.Evaluations.Add(s);
            Save();
        }

        public void Delete(Evaluations s)
        {
            entities.Evaluations.Remove(s);
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