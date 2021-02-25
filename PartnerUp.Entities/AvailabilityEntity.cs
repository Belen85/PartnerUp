using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class AvailabilityEntity
    {
        private int _idAvailability, _idDancer;
        private string _day;
        private TimeSpan _startTime, _endTime;

        public int IdAvailability
        {
            get
            {
                return _idAvailability;
            }

            set
            {
                _idAvailability = value;
            }
        }

        public int IdDancer
        {
            get
            {
                return _idDancer;
            }

            set
            {
                _idDancer = value;
            }
        }

        public string Day
        {
            get
            {
                return _day;
            }

            set
            {
                _day = value;
            }
        }

        public TimeSpan StartTime
        {
            get
            {
                return _startTime;
            }

            set
            {
                _startTime = value;
            }
        }

        public TimeSpan EndTime
        {
            get
            {
                return _endTime;
            }

            set
            {
                _endTime = value;
            }
        }
    }
}
