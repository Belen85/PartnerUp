using NetFlask.DAL.Repositories;
using PartnerUp.Entities;
using PartnerUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerUp.Repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<SP_UserEntity> _spUserRepository;
        public UnitOfWork(string connectionString)
        {
            _spUserRepository = new SpUserRepository(connectionString);
        }

        #region Register

        public bool SaveUser(UserModel user)
        {
            //    byte[] salt;
            //new rngcryptoserviceprovider().getbytes(salt = new byte[16]);
            //var pbkdf2 = new rfc2898derivebytes(password, salt, 100000);
            //byte[] hash = pbkdf2.getbytes(20);
            //byte[] hashbytes = new byte[36];
            //array.copy(salt, 0, hashbytes, 0, 16);
            //    array.copy(hash, 0, hashbytes, 16, 20);
            //    string savedpasswordhash = convert.tobase64string(hashbytes);

            SP_UserEntity us = new SP_UserEntity();
            us.Name = user.Name;
            us.LastName = user.LastName;
            us.Email = user.Email;
            us.Password = user.Password;  //comme je peux le convertir bit | string
            us.Image = user.Image;
            return _spUserRepository.Insert(us);
        }
        #endregion

    }
}
