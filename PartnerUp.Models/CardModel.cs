using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class CardModel
    {
        private int _idDancer, _idUser, _idDance, _idLevel, _idObjective, _idRole, idCity;
        private string _nickname, _comment;
        //private List<AvailabilityModel> _availabilities = new List<AvailabilityModel>();

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

        [Required]
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

        [Required]
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

        [Required]
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

        [Required]
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

        [Required]
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

        [Required]
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

        //public List<AvailabilityModel> Availabilities
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
