using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class SearchRepository : BaseRepository<SearchEntity>, IConcreteRepository<SearchEntity>
    {
        public SearchRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(SearchEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SearchEntity> Get()
        {
            throw new NotImplementedException();
        }

        public SearchEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SearchEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(SearchEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
