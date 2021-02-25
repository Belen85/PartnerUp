using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class CardEntity
    {
        private int _idDancer, _idUser, _idDance, _idLevel, _idObjective, _idRole, idCity;
        private string _nickname, _comment;
        //private List<AvailabilityEntity> _availabilities;

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

        public int IdUser
        {
            get
            {
                return _idUser;
            }

            set
            {
                _idUser = value;
            }
        }

        
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

     
        public int IdRole
        {
            get
            {
                return _idRole;
            }

            set
            {
                _idRole = value;
            }
        }

    
        public int IdCity
        {
            get
            {
                return idCity;
            }

            set
            {
                idCity = value;
            }
        }

       
        public string Nickname
        {
            get
            {
                return _nickname;
            }

            set
            {
                _nickname = value;
            }
        }

        public string Comment
        {
            get
            {
                return _comment;
            }

            set
            {
                _comment = value;
            }
        }

        //public List<AvailabilityEntity> Availabilities
        //{
        //    get
        //    {
        //        return _availabilities;
        //    }

        //    set
        //    {
        //        _availabilities = value;
        //    }
        //}
    }
}
