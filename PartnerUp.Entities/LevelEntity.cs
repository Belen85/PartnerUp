using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class LevelEntity
    {
        private int _idLevel;
        private string _level;

        public int IdLevel
        {
            get
            {
                return _idLevel;
            }

            set
            {
                _idLevel = value;
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
    }
}
