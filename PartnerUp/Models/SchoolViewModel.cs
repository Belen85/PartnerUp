using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class SchoolViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private string _titleSchools;

        private string _filterDance;
        private List<DanceModel> _danceModel;

        private string _filterCity;
        private List<CityModel> _cityModel;

        private List<SchoolModel> _listSchools;

        public SchoolViewModel()
        {
            TitleSchools = "Schools";
            FilterDance = "Dance";
            FilterCity = "City";
            DanceModel = ctx.GetAllDance();
            CityModel = ctx.GetAllCity();
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

        public string TitleSchools
        {
            get
            {
                return _titleSchools;
            }

            set
            {
                _titleSchools = value;
            }
        }

        public List<SchoolModel> ListSchools
        {
            get
            {
                return _listSchools;
            }

            set
            {
                _listSchools = value;
            }
        }
    }
}