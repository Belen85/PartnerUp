using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class DanceRepository : BaseRepository<DanceEntity>, IConcreteRepository<DanceEntity>
    {
        public DanceRepository(string Cnstr) : base(Cnstr)
        {
           
        }
        public bool Delete(DanceEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<DanceEntity> Get()
        {
            string requete = "Select * from Dance";
            return base.Get(requete);
        }

        public DanceEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(DanceEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(DanceEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
