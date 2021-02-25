using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class CardRepository : BaseRepository<CardEntity>, IConcreteRepository<CardEntity>
    {
        public CardRepository(string Cnstr) : base(Cnstr)
        { 
        }
        public bool Delete(CardEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<CardEntity> Get()
        {
            throw new NotImplementedException();
        }

        public CardEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CardEntity toInsert)
        {
            string requete = @"INSERT INTO DancerProfile
            (Nickname, Comment, CreationDate, IdUser, IdDance, IdLevel, IdObjective, IdRole, IdCity)
             VALUES
             (@Nickname, @Comment, GETDATE(), @IdUser, @IdDance, @IdLevel, @IdObjective, @IdRole, @IdCity)";
            return base.Insert(toInsert, requete);
        }

        public bool Update(CardEntity toUpdate)
        {
            throw new NotImplementedException();
        }

      

    }
}
