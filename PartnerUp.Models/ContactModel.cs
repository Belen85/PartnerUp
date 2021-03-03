using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class ContactModel
    {
        private int _idUserTo, _idUserFrom;
        private string _image, _nickname;

        public int IdUserTo
        {
            get
            {
                return _idUserTo;
            }

            set
            {
                _idUserTo = value;
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

        public int IdUserFrom
        {
            get
            {
                return _idUserFrom;
            }

            set
            {
                _idUserFrom = value;
            }
        }
    }
}
