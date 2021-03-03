using PartnerUp.DAL.Repositories;
using PartnerUp.Entities;
using PartnerUp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PartnerUp.Repositories
{
    public class UnitOfWork
    {
        IConcreteRepository<SP_UserEntity> _spUserRepository;
        IConcreteRepository<DanceEntity> _danceRepository;
        IConcreteRepository<LevelEntity> _levelRepository;
        IConcreteRepository<RoleEntity> _roleRepository;
        IConcreteRepository<ObjectiveEntity> _objectiveRepository;
        IConcreteRepository<CityEntity> _cityRepository;
        IConcreteRepository<CardEntity> _cardRepository;
        IConcreteRepository<PresentationCardEntity> _presentationCardRepository;
        IConcreteRepository<ContactEntity> _contactRepository;
        IConcreteRepository<MessageEntity> _messageRepository;
        IConcreteRepository<SendMessageEntity> _sendMessageRepository;
        //IConcreteRepository<AvailabilityEntity> _availabilityRepository;
    
        public UnitOfWork(string connectionString)
        {
            _spUserRepository = new SpUserRepository(connectionString);
            _danceRepository = new DanceRepository(connectionString);
            _levelRepository = new LevelRepository(connectionString);
            _roleRepository = new RoleRepository(connectionString);
            _objectiveRepository = new ObjectiveRepository(connectionString);
            _cityRepository = new CityRepository(connectionString);
            _cardRepository = new CardRepository(connectionString);
            _presentationCardRepository = new PresentationCardRepository(connectionString);
            _contactRepository = new ContactRepository(connectionString);
            _messageRepository = new MessageRepository(connectionString);
            _sendMessageRepository = new SendMessageRepository(connectionString);
            //_availabilityRepository = new AvailabilityRepository(connectionString);
        }

        #region Register/Login

        public bool SaveUser(UserModel user)
        {
            //string uniqueFileName = UploadedFile(user);

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

        //public string UploadedFile(UserModel user)
        //{
        //    string uniqueFileName = null;
        //    if (user.Image != null)
        //    {
        //        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + user.Image.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            user.Image.CopyTo(fileStream);
        //        }
        //    }
        //    return uniqueFileName;
        //}


        public UserModel UserAuth(LoginModel lm)
        {
            SP_UserEntity ue = ((SpUserRepository)_spUserRepository).GetFromLogin(lm.Email, lm.Password);
            if (ue != null)
            {
                return new UserModel()
                {
                    IdUser = ue.IdUser,
                    Name = ue.Name,
                    LastName = ue.LastName,
                    Email = ue.Email,
                    Image = ue.Image
                };
            }
            else
            {
                return null;
            }
            
        }
        #endregion

        #region Profile

        public List<DanceModel> GetAllDance()
        {
            List<DanceModel> ldm = new List<DanceModel>();
            List<DanceEntity> lde = _danceRepository.Get();
            foreach (DanceEntity item in lde)
            {
                DanceModel dm = new DanceModel();
                dm.IdDance = item.IdDance;
                dm.DanceName = item.DanceName;
                ldm.Add(dm);
            }
            return ldm;
        }

        public List<LevelModel> GetAllLevel()
        {
            List<LevelModel> llm = new List<LevelModel>();
            List<LevelEntity> lle = _levelRepository.Get();
            foreach (LevelEntity item in lle)
            {
                LevelModel lm = new LevelModel();
                lm.IdLevel = item.IdLevel;
                lm.Level = item.Level;
                llm.Add(lm);

            }
            return llm;
        }

        public List<RoleModel> GetAllRole()
        {
            List<RoleModel> lrm = new List<RoleModel>();
            List<RoleEntity> lre = _roleRepository.Get();
            foreach  (RoleEntity item in lre)
            {
                RoleModel rm = new RoleModel();
                rm.IdRole = item.IdRole;
                rm.Role = item.Role;
                lrm.Add(rm);

            }
            return lrm;
        }

        public List<ObjectiveModel> GetAllObjective()
        {
            List<ObjectiveModel> lom = new List<ObjectiveModel>();
            List<ObjectiveEntity> loe = _objectiveRepository.Get();
            foreach (ObjectiveEntity item in loe)
            {
                ObjectiveModel om = new ObjectiveModel();
                om.IdObjective = item.IdObjective;
                om.Objective = item.Objective;
                lom.Add(om);
            }
            return lom;
        }

        public List<CityModel> GetAllCity()
        {
            List<CityModel> lcm = new List<CityModel>();
            List<CityEntity> lce = _cityRepository.Get();
            foreach (CityEntity item in lce)
            {
                CityModel cm = new CityModel();
                cm.IdCity = item.IdCity;
                cm.City = item.City;
                lcm.Add(cm);

            }
            return lcm;
        }

        public bool SaveCard(CardModel card)
        {
            //Je dois traiter separement les deux insert d'availability et du card???


            CardEntity ce = new CardEntity();
            ce.IdUser = card.IdUser;
            ce.IdDance = card.IdDance;
            ce.IdLevel = card.IdLevel;
            ce.IdObjective = card.IdObjective;
            ce.IdRole = card.IdRole;
            ce.IdCity = card.IdCity;
            ce.Nickname = card.Nickname;
            ce.Comment = card.Comment;
            return _cardRepository.Insert(ce);

            //Solution 1  - Creer une nouvelle methode insert permettant de recevoir l idDance apres insertion dans la db
            //Solution 2  - creer une procedure stockee qui va inserer la card et l avaibility
            //List<AvailabilityEntity> la = new List<AvailabilityEntity>();
            //foreach (AvailabilityEntity item1 in la)
            //{
            //    AvailabilityEntity ae = new AvailabilityEntity();
            //    ae.IdDancer = card.Availabilities[count].IdDancer;
            //    ae.Day = card.Availabilities[count].Day;
            //    ae.StartTime = card.Availabilities[count].StartTime;  //Comment va reconannitre qu'il s'agit du format (hh:mm)???  car le type dans le table est time
            //    ae.EndTime = card.Availabilities[count].EndTime;
            //    count++;
            //    _availabilityRepository.Insert(ae);
            //}



        }

        public List<PresentationCardModel> GetAllCard(int IdUser)
        {
            List<PresentationCardModel> lpm = new List<PresentationCardModel>();
            List<PresentationCardEntity> lpe = ((PresentationCardRepository)_presentationCardRepository).GetAllCardsByIdUser(IdUser);
            foreach (PresentationCardEntity item in lpe)
            {
                PresentationCardModel pm = new PresentationCardModel();
                pm.Image = item.Image;
                pm.Nickname = item.Nickname;
                pm.DanceName = item.DanceName;
                pm.Level = item.Level;
                pm.Objective = item.Objective;
                pm.Role = item.Role;
                pm.City = item.City;
                pm.Comment = item.Comment;
                lpm.Add(pm);

            }
            return lpm;
        
        }


        #endregion

        #region Search

        public List<PresentationCardModel> CheckInfo(SearchModel search)
        {
            List<PresentationCardEntity> lce = ((PresentationCardRepository)_presentationCardRepository).GetFromSearch(search.DanceName, search.Level, search.Objective, search.Role, search.City);
            if (lce != null)
            {
                List<PresentationCardModel> lpc = new List<PresentationCardModel>();
                foreach (PresentationCardEntity item in lce)
                {
                    PresentationCardModel pm = new PresentationCardModel();
                    pm.IdUser = item.IdUser;
                    pm.Image = item.Image;
                    pm.DanceName = item.DanceName;
                    pm.Level = item.Level;
                    pm.Objective = item.Objective;
                    pm.Role = item.Role;
                    pm.City = item.City;
                    pm.Comment = item.Comment;
                    lpc.Add(pm);
                }
                return lpc;
            }
            else
            {
                return null;
            }
            
            
        
        }
        #endregion

        #region Messages

        public List<ContactModel> CheckContact(int IdUserFrom)
        {
            List<ContactEntity> lce = ((ContactRepository)_contactRepository).GetFromIdUserFrom(IdUserFrom);
            if (lce != null)
            {
                List<ContactModel> lcm = new List<ContactModel>();
                foreach (ContactEntity item in lce)
                {
                    ContactModel cm = new ContactModel();  //Ce n'est pas grave si je ne prends pas idUserFrom????
                    cm.IdUserFrom = item.IdUserFrom;
                    cm.IdUserTo = item.IdUserTo;
                    cm.Image = item.Image;
                    cm.Nickname = item.Nickname;
                    lcm.Add(cm);
                }
                return lcm;
            }
            else
            {
                return null;
            }
        }

        public List<MessageModel> GetAllMessage(ContactModel contact)
        {
            List<MessageEntity> lme = ((MessageRepository)_messageRepository).GetAllMessageFromToFrom(contact.IdUserTo, contact.IdUserFrom);
            List<MessageModel> lmm = new List<MessageModel>();
            foreach (MessageEntity item in lme)
            {
                MessageModel mm = new MessageModel();
                mm.IdUserFrom = item.IdUserFrom;
                mm.IdUserTo = item.IdUserTo;
                mm.Nickname = item.Nickname;
                mm.Text = item.Text;
                mm.Date = item.Date;
                lmm.Add(mm);
            }
            return lmm;
        }

        public bool SaveMessage(SendMessageModel send)
        {

            SendMessageEntity se = new SendMessageEntity();
            se.IdUserFrom = send.IdUserFrom;
            se.IdUserTo = send.IdUserTo;
            se.Text = send.Text;
            return _sendMessageRepository.Insert(se);
        }
        #endregion

    }
}
