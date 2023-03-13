using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;

namespace BackEnd.Repositories
{
    public class UserRepository
    {
        private static List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                Role = "manager"
            }
        };

        public static User Get(string username, string password)
        {
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

        public static User CreateUser(string username, string password, string role)
        {
            var newUser = new User
            {
                Id = users.Count + 1,
                Username = username,
                Password = password,
                Role = role
            };

            users.Add(newUser);

            return newUser;
        }

    }
}