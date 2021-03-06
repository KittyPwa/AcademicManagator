﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{
    public class AcademyRepository
    {
        private AcademyEntities entities;

        public AcademyRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Academies> All()
        {
            return entities.Academies;
        }

        public Academies GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }

        public IEnumerable<Academies> AllByName(String name)
        {
            return All().Where(o => o.Name == name);
        }

        public void Add(Academies s)
        {
            entities.Academies.Add(s);
            Save();
        }

        public void Delete(Academies s)
        {
            entities.Academies.Remove(s);
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