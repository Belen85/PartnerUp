using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class ObjectiveRepository : BaseRepository<ObjectiveEntity>, IConcreteRepository<ObjectiveEntity>
    {
        public ObjectiveRepository(string Cnstr) : base(Cnstr)
        { 
        
        }
        public bool Delete(ObjectiveEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ObjectiveEntity> Get()
        {
            string requete = "Select * from Objective";
            return base.Get(requete);
        }

        public ObjectiveEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ObjectiveEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ObjectiveEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
