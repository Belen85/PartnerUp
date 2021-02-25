using PartnerUp.Infra;
using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class ProfileViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private UserModel _connecterUser;
        private string _titleProfile;
        private string _titleSectionPersonalData;
        private string _titleSectionCardCreation;
        private string _titleSectionCards;
        private string _titleNickname;
        private string _filterDance;
        private string _filterLevel;
        private string _filterRole;
        private string _filterObjective;
        private string _filterCity;

        private List<DanceModel> _danceModel;
        private List<LevelModel> _levelModel;
        private List<RoleModel> _roleModel;
        private List<ObjectiveModel> _objectiveModel;
        private List<CityModel> _cityModel;

        private CardModel _cardModel;

        private List<PresentationCardModel> _presentationCardModel;

        public ProfileViewModel()
        {
            //Variables primitives
            TitleProfile = "Profile";
            TitleSectionPersonalData = "Personal Data";
            TitleSectionCardCreation = "Dancer Card Creation";
            TitleSectionCards = "My dancers' profiles";
            TitleNickname = "Nickname";
            FilterDance = "Dance";
            FilterLevel = "Level";
            FilterRole = "Role";
            FilterObjective = "Objective";
            FilterCity = "City";

            //Section Personal Data
            ConnecterUser = SessionUtils.ConnectedUser;

            //Section Card Creation
            DanceModel = ctx.GetAllDance();
            LevelModel = ctx.GetAllLevel();
            RoleModel = ctx.GetAllRole();
            ObjectiveModel = ctx.GetAllObjective();
            CityModel = ctx.GetAllCity();

            //Section presentation de Cartes
            PresentationCardModel = ctx.GetAllCard(SessionUtils.ConnectedUser.IdUser);
        }

        public string TitleProfile
        {
            get
            {
                return _titleProfile;
            }

            set
            {
                _titleProfile = value;
            }
        }

        public UserModel ConnecterUser
        {
            get
            {
                return _connecterUser;
            }

            set
            {
                _connecterUser = value;
            }
        }

        public List<DanceModel> DanceModel
        {
            get
            {
                return _danceModel;
            }

            set
            {
                _danceModel = value;
            }
        }

        public string TitleSectionPersonalData
        {
            get
            {
                return _titleSectionPersonalData;
            }

            set
            {
                _titleSectionPersonalData = value;
            }
        }

        public string TitleSectionCardCreation
        {
            get
            {
                return _titleSectionCardCreation;
            }

            set
            {
                _titleSectionCardCreation = value;
            }
        }

        public string TitleSectionCards
        {
            get
            {
                return _titleSectionCards;
            }

            set
            {
                _titleSectionCards = value;
            }
        }

        public string FilterDance
        {
            get
            {
                return _filterDance;
            }

            set
            {
                _filterDance = value;
            }
        }

        public List<LevelModel> LevelModel
        {
            get
            {
                return _levelModel;
            }

            set
            {
                _levelModel = value;
            }
        }

        public string FilterLevel
        {
            get
            {
                return _filterLevel;
            }

            set
            {
                _filterLevel = value;
            }
        }

        public string TitleNickname
        {
            get
            {
                return _titleNickname;
            }

            set
            {
                _titleNickname = value;
            }
        }

        public List<RoleModel> RoleModel
        {
            get
            {
                return _roleModel;
            }

            set
            {
                _roleModel = value;
            }
        }

        public string FilterRole
        {
            get
            {
                return _filterRole;
            }

            set
            {
                _filterRole = value;
            }
        }

        public string FilterObjective
        {
            get
            {
                return _filterObjective;
            }

            set
            {
                _filterObjective = value;
            }
        }

        public List<ObjectiveModel> ObjectiveModel
        {
            get
            {
                return _objectiveModel;
            }

            set
            {
                _objectiveModel = value;
            }
        }

        public string FilterCity
        {
            get
            {
                return _filterCity;
            }

            set
            {
                _filterCity = value;
            }
        }

        public List<CityModel> CityModel
        {
            get
            {
                return _cityModel;
            }

            set
            {
                _cityModel = value;
            }
        }

        public CardModel CardModel
        {
            get
            {
                return _cardModel;
            }

            set
            {
                _cardModel = value;
            }
        }

        public List<PresentationCardModel> PresentationCardModel
        {
            get
            {
                return _presentationCardModel;
            }

            set
            {
                _presentationCardModel = value;
            }
        }
    }
}