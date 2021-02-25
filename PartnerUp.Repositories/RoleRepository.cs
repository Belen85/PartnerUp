using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class RoleRepository : BaseRepository<RoleEntity>, IConcreteRepository<RoleEntity>
    {
        public RoleRepository(string Cnstr) : base(Cnstr)
        { 
        
        }
        public bool Delete(RoleEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<RoleEntity> Get()
        {
            string requete = "Select * from Role";
            return base.Get(requete);
        }

        public RoleEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RoleEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(RoleEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
