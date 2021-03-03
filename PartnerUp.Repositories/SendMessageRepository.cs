using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class SendMessageRepository : BaseRepository<SendMessageEntity>, IConcreteRepository<SendMessageEntity>
    {
        public SendMessageRepository(string Cnstr) : base(Cnstr)
        {
        }
        public bool Delete(SendMessageEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SendMessageEntity> Get()
        {
            throw new NotImplementedException();
        }

        public SendMessageEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SendMessageEntity toInsert)
        {
            string requete = @"INSERT INTO Message
            (IdUserTo, IdUserFrom, Text, Date)
             VALUES
             (@IdUserTo, @IdUserFrom, @Text, GETDATE())";
            return base.Insert(toInsert, requete);
        }

        public bool Update(SendMessageEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
