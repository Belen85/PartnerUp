using NetFlask.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class SpUserRepository : BaseRepository<SP_UserEntity>, IConcreteRepository<SP_UserEntity>
    {
        public SpUserRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(SP_UserEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SP_UserEntity> Get()
        {
            throw new NotImplementedException();
        }

        public SP_UserEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SP_UserEntity toInsert)
        {
            //toInsert.Name + " " + toInsert.LastName + " " + toInsert.Email + " " + toInsert.Password + " " + toInsert.Image;
            string requete = @"exec [SP_User_Insert]" + toInsert.Name + "," + toInsert.LastName + "," + toInsert.Email + "," + toInsert.Password + "," + toInsert.Image;
            return base.Insert(toInsert, requete);
        }

        public bool Update(SP_UserEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
