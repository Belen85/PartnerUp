using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class MessageRepository : BaseRepository<MessageEntity>, IConcreteRepository<MessageEntity>
    {
        public MessageRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(MessageEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MessageEntity> Get()
        {
            throw new NotImplementedException();
        }

        public MessageEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MessageEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(MessageEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public List<MessageEntity> GetAllMessageFromToFrom(int IdUserTo, int IdUserFrom) 
        {
            string requete = @"SELECT [Message].IdMessage, [DancerProfile].Nickname, [Message].IdUserFrom, [Message].IdUserTo, [Message].Text, [Message].[Date] FROM [Message]
                            INNER JOIN [User] ON [User].IdUser = [Message].IdUserFrom
                            INNER JOIN [DancerProfile] ON [DancerProfile].IdUser = [User].IdUser
                            WHERE (IdUserFrom =" + IdUserFrom + " OR IdUserFrom=" + IdUserTo + ") AND (IdUserTo=" + IdUserTo + " OR IdUserTo =" + IdUserFrom + ") " +
                              "GROUP BY [DancerProfile].Nickname, [Message].IdUserFrom, [Message].IdUserTo, [Message].Text, [Message].[Date],[Message].IdMessage" +
                              " ORDER BY [Message].IdMessage ASC";

            return base.Get(requete);

        }
    }
}
