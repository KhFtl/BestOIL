using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Services.Interfaces
{
    public interface IUser
    {
        string UserName { get; }
        string PasswordHash { get; }
        string FileName { get; }
        bool CheckPassword(string password);
        void SaveToFile();
        List<IUser> LoadUser();
        void RegisterUser(string username, string password);
    }
}
