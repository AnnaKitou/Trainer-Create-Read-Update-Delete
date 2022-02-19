namespace ProjectAssignment.Migrations
{
    using ProjectAssignment.Models;
    using ProjectAssignment.MyDataBase;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectAssignment.MyDataBase.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjectAssignment.MyDataBase.AppDbContext context)
        {

        }
    }
}
