using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcademicManagator.Util;

namespace AcademicManagator.Models
{

    public class UserRepository
    {
        private AcademyEntities entities;

        public UserRepository(AcademyEntities e)
        {
            entities = e;
        }

        public IEnumerable<Users> All()
        {
            return entities.Users;
        }

        public Users GetById(int id)
        {
            return All().FirstOrDefault(o => o.Id.ToString() == id.ToString());
        }


        public void Add(Users s)
        {
            entities.Users.Add(s);
            Save();
        }

        public void Delete(Users s)
        {
            entities.Users.Remove(s);
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