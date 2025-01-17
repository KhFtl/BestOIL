using BestOIL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BestOIL.Services
{
    public class User : IUser
    {

        public string FileName { get; }

        public string UserName{ get; private set; }

        public string PasswordHash { get; private set; }

        public User()
        {
            FileName = "users.dat";
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            { 
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public bool CheckPassword(string password)
        {
            return PasswordHash == HashPassword(password);
        }

        public List<IUser> LoadUser()
        {
           var users = new List<IUser>();
            if (System.IO.File.Exists(FileName))
            {
                var lines = System.IO.File.ReadAllLines(FileName);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    var user = new User
                    {
                        UserName = parts[0],
                        PasswordHash = parts[1]
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public void RegisterUser(string username, string password)
        {
            var users = LoadUser();
            foreach (var user in users)
            {
                if (user.UserName == username)
                {
                    throw new Exception($"Користувач з логіном {username} вже зареєстровано");
                }
            }
            UserName = username;
            PasswordHash = HashPassword(password);
            SaveToFile();
        }

        public void SaveToFile()
        {
            string userData = $"{UserName}:{PasswordHash}";
            System.IO.File.AppendAllLines(FileName, new string[] { userData });
        }
    }
}
