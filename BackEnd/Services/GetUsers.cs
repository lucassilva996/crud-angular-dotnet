using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using BackEnd.Repositories;

namespace BackEnd.Settings
{
    public class GetUsers
    {
        private readonly UserRepository userRepository;

        public GetUsers()
        {
            userRepository = new UserRepository();
        }

        public User GetUser(string username, string password)
        {
            var user = UserRepository.Get(username, password);
            return user;
        }
    }
}