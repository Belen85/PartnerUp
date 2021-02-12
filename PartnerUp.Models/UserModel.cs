using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Models
{
    public class UserModel
    {
        private string _name, _lastName, _email, _password, _verifyPassword, _image;

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(256)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
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

        
        [Required]
        [MaxLength(256)]
        public string Password
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

        [Required]
        [MaxLength(256)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string VerifyPassword
        {
            get
            {
                return _verifyPassword;
            }

            set
            {
                _verifyPassword = value;
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
    }
}
