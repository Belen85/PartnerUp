using PartnerUp.Infra;
using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class ProfileViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private UserModel _connecterUser;
        private string _titleProfile;

        public ProfileViewModel()
        {
            //Variables primitives
            TitleProfile = "Profile";

            ConnecterUser = SessionUtils.ConnectedUser;
        }

        public string TitleProfile
        {
            get
            {
                return _titleProfile;
            }

            set
            {
                _titleProfile = value;
            }
        }

        public UserModel ConnecterUser
        {
            get
            {
                return _connecterUser;
            }

            set
            {
                _connecterUser = value;
            }
        }
    }
}