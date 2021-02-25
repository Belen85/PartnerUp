using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class CityEntity
    {
        private int _idCity;
        private string _city;

        public int IdCity
        {
            get
            {
                return _idCity;
            }

            set
            {
                _idCity = value;
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
