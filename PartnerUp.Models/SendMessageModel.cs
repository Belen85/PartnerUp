using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class SendMessageModel
    {
        private int _idUserTo, _idUserFrom;
        private string _text;

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

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }
    }
}
