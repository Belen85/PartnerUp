using NetFlask.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IConcreteRepository<UserEntity>
    {
        public UserRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(UserEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> Get()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UserEntity toInsert)
        {
            string requete = @"exec [SP_User_Insert]";
            return base.Insert(toInsert, requete);
        }

        public bool Update(UserEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
