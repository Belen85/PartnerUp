using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class CityRepository : BaseRepository<CityEntity>, IConcreteRepository<CityEntity>
    {
        public CityRepository(string Cnstr) : base(Cnstr)
        { 
        
        }
        public bool Delete(CityEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<CityEntity> Get()
        {
            string requete = "Select * from City";
            return base.Get(requete);
        }

        public CityEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CityEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(CityEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
