using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class ObjectiveModel
    {
        private int _idObjective;
        private string _objective;

        public int IdObjective
        {
            get
            {
                return _idObjective;
            }

            set
            {
                _idObjective = value;
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
    }
}
