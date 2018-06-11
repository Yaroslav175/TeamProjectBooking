using ClassLibrary.Interfaces;
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
        private User _authorizedUser;

        public void RegisterUser(User user)
        {
            user.Id = _generalData.Users.Count > 0 ? _generalData.Users.Max(u => u.Id) + 1 : 1;
            _generalData.Users.Add(user);
            Save();
        }
        public bool Authorize(string login, string password)
        {
            var user = _generalData.Users.FirstOrDefault(u => u.Login == login && u.Password == GetHash(password));
            if (user != null)
            {
                user.Favourites = LoadUserFavourites(user.Id);
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
        public static string GetHash(string password)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private List<Favourite> LoadUserFavourites(int userId)
        {
            try
            {
                using (var sr = new StreamReader(GetUserFavouritesPath(userId)))
                {
                    using (var jsonReader = new JsonTextReader(sr))
                    {
                        var serializer = new JsonSerializer();
                        var favourites = serializer.Deserialize<List<Favourite>>(jsonReader);
                        foreach (var f in favourites)
                            f.Station = _generalData.Stations.First(st => st.Id == f.StationId);
                        return favourites;
                    }
                }
            }
            catch
            {
                return new List<Favourite>();
            }
        }
        public void SaveUserFavourites()
        {
            using (var sw = new StreamWriter(GetUserFavouritesPath(_authorizedUser.Id)))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, _authorizedUser.Favourites);
                }
            }
        }
        private string GetUserFavouritesPath(int userId) => Path.Combine(DataFolder, userId.ToString() + ".json");








    }
}
