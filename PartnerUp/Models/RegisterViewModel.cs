using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class RegisterViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private UserModel _userModel;
        private string _title;

        public RegisterViewModel()
        {
            //Variables primitives
            Title = "Register";
            //UserModel1 = ctx.SaveUser(UserModel user);
        }

        public UserModel UserModel
        {
            get
            {
                return _userModel;
            }

            set
            {
                _userModel = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
    }
}