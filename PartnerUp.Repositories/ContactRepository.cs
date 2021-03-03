using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class ContactRepository : BaseRepository<ContactEntity>, IConcreteRepository<ContactEntity>
    {
        public ContactRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(ContactEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ContactEntity> Get()
        {
            throw new NotImplementedException();
        }

        public ContactEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ContactEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ContactEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public List<ContactEntity> GetFromIdUserFrom(int IdUserFrom)
        {
            string requete = @"SELECT [Message].IdUserTo,  [User].Image, [DancerProfile].Nickname FROM [Message]
                           INNER JOIN [User] ON [Message].IdUserTo = [User].IdUser
                           INNER JOIN [DancerProfile] ON [DancerProfile].IdUser = [User].IdUser
                            WHERE [Message].IdUserFrom =" + IdUserFrom + " GROUP BY [Message].IdUserTo, [User].Image, [DancerProfile].Nickname";
            return base.Get(requete);
        }
    }
}
