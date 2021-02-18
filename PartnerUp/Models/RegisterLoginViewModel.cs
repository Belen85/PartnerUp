using PartnerUp.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PartnerUp.Models
{
    public class RegisterLoginViewModel
    {
        private UnitOfWork ctx = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private UserModel _userModel;
        private string _titleRegister;
        private string _titleContact;
        private LoginModel _loginModel;

        public RegisterLoginViewModel()
        {
            //Variables primitives
            TitleRegister = "Register";
            TitleContact = "Contact";
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

        public string TitleRegister
        {
            get
            {
                return _titleRegister;
            }

            set
            {
                _titleRegister = value;
            }
        }

        public string TitleContact
        {
            get
            {
                return _titleContact;
            }

            set
            {
                _titleContact = value;
            }
        }

        public LoginModel LoginModel
        {
            get
            {
                return _loginModel;
            }

            set
            {
                _loginModel = value;
            }
        }
    }
}