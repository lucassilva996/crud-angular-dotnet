using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons {get; set;}
        public DbSet<User> Users {get; set;}

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}