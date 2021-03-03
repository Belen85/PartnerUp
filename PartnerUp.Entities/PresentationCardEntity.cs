using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class PresentationCardEntity
    {
        private int _idUser;
        private string _image, _nickname, _danceName, _level, _objective, _role, _city, _comment;

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
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
    }
}
