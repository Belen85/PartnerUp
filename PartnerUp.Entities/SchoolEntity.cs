using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class SchoolEntity
    {
        private string _name, _website;
        private string _nameLocation, _number, _street, _city, _country, _department, _postalcode, _linkGoogle;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Website
        {
            get
            {
                return _website;
            }

            set
            {
                _website = value;
            }
        }

        public string NameLocation
        {
            get
            {
                return _nameLocation;
            }

            set
            {
                _nameLocation = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
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

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public string Postalcode
        {
            get
            {
                return _postalcode;
            }

            set
            {
                _postalcode = value;
            }
        }

        public string LinkGoogle
        {
            get
            {
                return _linkGoogle;
            }

            set
            {
                _linkGoogle = value;
            }
        }
    }
}
