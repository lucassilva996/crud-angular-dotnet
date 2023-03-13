using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using BackEnd.Repositories;
using BackEnd.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TokenController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Autentication([FromBody] User model)
        {
            var user = UserRepository.Get(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário e senha digitados são inválidos!" });
            }

            var tokenGenerator = new TokenGeneratorService("mysecret", "myissuer", "myaudience", 30);

            var token = tokenGenerator.GenerateToken(model.Username, model.Password);

            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}