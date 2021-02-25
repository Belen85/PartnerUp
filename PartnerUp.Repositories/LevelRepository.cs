using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class LevelRepository : BaseRepository<LevelEntity>, IConcreteRepository<LevelEntity>
    {
        public LevelRepository(string Cnstr) : base(Cnstr)
        { 
        }
        public bool Delete(LevelEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<LevelEntity> Get()
        {
            string requete = "Select * from Level";
            return base.Get(requete);
        }

        public LevelEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LevelEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(LevelEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
