using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
   public interface IRepository 
    {
        bool Authorize(string login, string password);
        void RegisterUser(User user);


    }
}
