using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class AvailabilityRepository : BaseRepository<AvailabilityEntity>, IConcreteRepository<AvailabilityEntity>
    {
        public AvailabilityRepository(string Cnstr) : base(Cnstr)
        { 
        }
        public bool Delete(AvailabilityEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<AvailabilityEntity> Get()
        {
            throw new NotImplementedException();
        }

        public AvailabilityEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(AvailabilityEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(AvailabilityEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
