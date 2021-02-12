using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class UserEntity
    {
        private int _idUser;
        private string _name, _lastName, _email, _image, _salt;  //Salt est un CHAR(8 en sql), quel est l'equivalente en ASPNET??
        private bool _admin;
        private byte _password;  //equivalent a varbinary(32) en SQL, est-ce correct?

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

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

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

        public string Salt
        {
            get
            {
                return _salt;
            }

            set
            {
                _salt = value;
            }
        }

        public bool Admin
        {
            get
            {
                return _admin;
            }

            set
            {
                _admin = value;
            }
        }

        public byte Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
    }
}
