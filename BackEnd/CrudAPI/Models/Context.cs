using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Models
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons {get; set;}

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}