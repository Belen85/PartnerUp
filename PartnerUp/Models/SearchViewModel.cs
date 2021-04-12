using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class SearchViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

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

        private List<PresentationCardModel> _listeCartes;



        public SearchViewModel()
        {
            //Variables primitives
            FilterDance = "Dance";
            FilterLevel = "Level";
            FilterRole = "Role";
            FilterObjective = "Objective";
            FilterCity = "City";

            //Section Filter Creation
            DanceModel = ctx.GetAllDance();
            LevelModel = ctx.GetAllLevel();
            RoleModel = ctx.GetAllRole();
            ObjectiveModel = ctx.GetAllObjective();
            CityModel = ctx.GetAllCity();
            //ListeCartes = ctx.CheckInfo(SearchModel search);
           
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

        public List<PresentationCardModel> ListeCartes
        {
            get
            {
                return _listeCartes;
            }

            set
            {
                _listeCartes = value;
            }
        }
    }
}