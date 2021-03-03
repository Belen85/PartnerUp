using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Entities
{
    public class MessageEntity
    {
        private int _idMessage, _idUserFrom, _idUserTo;
        private string _nickname, _text;
        private DateTime _date;

        public int IdMessage
        {
            get
            {
                return _idMessage;
            }

            set
            {
                _idMessage = value;
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

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }
    }
}
