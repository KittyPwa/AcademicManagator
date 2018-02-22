using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class ClassroomRepository
    {
        private ClassroomEntities entities;

        public ClassroomRepository(ClassroomEntities e)
        {
            entities = e;
        }

        public IEnumerable<Classrooms> All()
        {
            return entities.Classrooms;
        }

        public Classrooms GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Classrooms s)
        {
            entities.Classrooms.Add(s);
            Save();
        }

        public void Delete(Classrooms s)
        {
            entities.Classrooms.Remove(s);
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