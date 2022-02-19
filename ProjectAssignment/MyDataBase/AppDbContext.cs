using ProjectAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectAssignment.MyDataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("Sindesmos")
        {
            Database.SetInitializer<AppDbContext>(new DropCreateDatabaseAlways<AppDbContext>());

        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}