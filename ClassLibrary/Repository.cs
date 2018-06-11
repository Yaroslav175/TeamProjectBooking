using ClassLibrary.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Repository : IRepository
    {
        public class GeneralData
        {
            public List<HSEBuilding> Buildings { get; set; }
            public List<Room> Rooms { get; set; }
            public List<User> Users { get; set; }
        }
        private GeneralData _generalData;
        public User _authorizedUser;

        private const string DataFolder = "TeamProjectBooking2/ClassLibrary/Data";
        private const string FileName = "ts.json";

        public Repository()
        {

            _generalData = new GeneralData
            {
                Buildings = new List<HSEBuilding>(),
                Rooms = new List<Room>(),
                Users = new List<User>()

            };
           
        }

        public void RegisterUser(User user)
        {
            user.Id = _generalData.Users.Count > 0 ? _generalData.Users.Max(u => u.Id) + 1 : 1;
            _generalData.Users.Add(user);
            Save();
        }
        public bool Authorize(string login, string password)
        {
            var user = _generalData.Users.FirstOrDefault(u => u.Login == login && u.Password == Password.GetHash(password));
            if (user != null)
            {
                
                _authorizedUser = user;
                return true;
            }
            return false;
        }
        public void Save()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }
            using (var sw = new StreamWriter(Path.Combine(DataFolder, FileName)))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, _generalData);
                }
            }
        }
        
        
        






    }
}
