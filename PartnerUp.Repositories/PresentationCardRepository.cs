using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class PresentationCardRepository : BaseRepository<PresentationCardEntity>, IConcreteRepository<PresentationCardEntity>
    {
        public PresentationCardRepository(string Cnstr) : base(Cnstr)
        {

        }
        public bool Delete(PresentationCardEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PresentationCardEntity> Get()
        {
            throw new NotImplementedException();
        }

        public PresentationCardEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PresentationCardEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PresentationCardEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public List<PresentationCardEntity> GetAllCardsByIdUser(int IdUser)
        {
            string requete = @"SELECT [User].Image, [DancerProfile].Nickname, [Dance].DanceName, [Level].Level, [Objective].Objective, [Role].Role, [City].City, [DancerProfile].Comment
                            FROM [PartnerUp].[dbo].[User] INNER JOIN
                            [DancerProfile] ON DancerProfile.IdUser = [User].IdUser
                            INNER JOIN [Dance] ON Dance.IdDance = DancerProfile.IdDance
                            INNER JOIN [Level] ON Level.IdLevel = DancerProfile.IdLevel
                            INNER JOIN [Objective] ON Objective.IdObjective = DancerProfile.IdObjective
                            INNER JOIN [Role] ON Role.IdRole = DancerProfile.IdRole
                            INNER JOIN [City] ON City.IdCity = DancerProfile.IdCity
                            WHERE [User].IdUser=" + IdUser;
            return base.Get(requete);
        }

        public List<PresentationCardEntity> GetFromSearch(string DanceName, string Level, string Objective, string Role, string City)
        { 
         string requete = @"SELECT [User].Image, [DancerProfile].Nickname, [Dance].DanceName, [Level].Level, [Objective].Objective, [Role].Role, [City].City, [DancerProfile].Comment
                            FROM [PartnerUp].[dbo].[User] INNER JOIN
                            [DancerProfile] ON DancerProfile.IdUser = [User].IdUser
                            INNER JOIN [Dance] ON Dance.IdDance = DancerProfile.IdDance
                            INNER JOIN [Level] ON Level.IdLevel = DancerProfile.IdLevel
                            INNER JOIN [Objective] ON Objective.IdObjective = DancerProfile.IdObjective
                            INNER JOIN [Role] ON Role.IdRole = DancerProfile.IdRole
                            INNER JOIN [City] ON City.IdCity = DancerProfile.IdCity
                            WHERE [Dance].DanceName='" + DanceName + "' AND [Level].Level='" + Level + "' AND [Objective].Objective='" + Objective +
                             "' AND [Role].Role='" + Role + "' AND [City].City='" +City + "'";
            return base.Get(requete);

        }
    }
}
