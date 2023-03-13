using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;

namespace BackEnd.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();

            users.Add(new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                Role = "manager"
            });

            return users.Where(x => x.Username.ToLower() == username && x.Password == x.Password).First();
        }
    }
}