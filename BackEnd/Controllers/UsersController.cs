using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Interfaces;
using BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public IUsers _users;
        private readonly Context _context;

        public UsersController(IUsers users, Context context)
        {
            _users = users;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public string Users()
        {
            var users = _users.GetAllUsers();
            return users;
        }

        [HttpPost]
        public async Task<ActionResult<User>> SaveUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}