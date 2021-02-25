using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class DanceModel
    {
        private int _idDance;
        private string _danceName;

        public int IdDance
        {
            get
            {
                return _idDance;
            }

            set
            {
                _idDance = value;
            }
        }

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
    }
}
