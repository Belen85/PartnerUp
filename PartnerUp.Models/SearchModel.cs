using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class SearchModel
    {
        private string _danceName, _level, _objective, _role, _city;

        public string DanceName
        {
            get
            {
                return _danceName;
            }

            set
            {
                _danceName = value;
            }
        }

        public string Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }

        public string Objective
        {
            get
            {
                return _objective;
            }

            set
            {
                _objective = value;
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }
    }
}
