using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class SchoolRepository : BaseRepository<SchoolEntity>, IConcreteRepository<SchoolEntity>
    {
        public SchoolRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(SchoolEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SchoolEntity> Get()
        {
            throw new NotImplementedException();
        }

        public SchoolEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SchoolEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(SchoolEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public List<SchoolEntity> getAllSchoolsByCriteria(string City, int IdDance)
        {
            string requete = @"SELECT [Address].Name AS NameLocation, [Address].Number, [Address].Street, [Address].City, [Address].Country, [Address].Department,
                        [Address].PostalCode, [Address].LinkGoogle, [School].Name, [School].Website FROM Address
                        INNER JOIN SchoolAddress ON [Address].IdAddress = [SchoolAddress].IdAddress
                        INNER JOIN School ON [SchoolAddress].IdSchool = [School].IdSchool
                        INNER JOIN DanceSchool ON [School].IdSchool = [DanceSchool].IdSchool
                        INNER JOIN Dance ON [DanceSchool].IdDance = [Dance].IdDance
                        WHERE [Dance].IdDance=" + IdDance + "AND [Address].City ='" + City + "'";
            return base.Get(requete);
         }
    }
}
