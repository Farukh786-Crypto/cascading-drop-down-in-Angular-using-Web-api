using AngularWebApi.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApi.Model
{
    // when build failed check error list and check connection is on in server expolorer
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<CategoryMst> Categories { get; set; }
        public DbSet<CountryMst> countrymaster { get; set; }
        public DbSet<StateMst> statemaster { get; set; }
    }
}
