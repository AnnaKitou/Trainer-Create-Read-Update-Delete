namespace ProjectAssignment.Migrations
{
    using ProjectAssignment.Models;
    using ProjectAssignment.MyDataBase;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class Initializer : DbMigration
    {
        public override void Up()
        {
            AppDbContext db = new AppDbContext();

            Trainer t1 = new Trainer() { FirstName = "Anna", LastName = "Kitou", Age = 32, Subject = "Python" };
            Trainer t2 = new Trainer() { FirstName = "Christos", LastName = "Karamolegkos", Age = 31, Subject = "C#" };
            Trainer t3 = new Trainer() { FirstName = "AnnaMaria", LastName = "Kitou", Age = 34, Subject = "C++" };
            Trainer t4 = new Trainer() { FirstName = "Hector", LastName = "Krionasianos", Age = 45, Subject = "JQ" };
            Trainer t5 = new Trainer() { FirstName = "Christina", LastName = "Kourgiouni", Age = 35, Subject = "Javascript" };
            Trainer t6 = new Trainer() { FirstName = "Panos", LastName = "Kempas", Age = 63, Subject = "Python" };
            Trainer t7 = new Trainer() { FirstName = "Leon", LastName = "Ntokartos", Age = 45, Subject = "Cobol" };
            Trainer t8 = new Trainer() { FirstName = "Leo", LastName = "Ntokar", Age = 45, Subject = "C#" };
            Trainer t9 = new Trainer() { FirstName = "Artemis", LastName = "Kim", Age = 50, Subject = "Python" };
            Trainer t10 = new Trainer() { FirstName = "Anna", LastName = "Kimian", Age = 54, Subject = "JQ" };
            Trainer t11 = new Trainer() { FirstName = "Maria", LastName = "Kimiou", Age = 40, Subject = "C#" };
            Trainer t12 = new Trainer() { FirstName = "Giota", LastName = "Pavlou", Age = 54, Subject = "Python" };
            Trainer t13 = new Trainer() { FirstName = "Eleni", LastName = "Seinchenko", Age = 22, Subject = "JQ" };
            Trainer t14 = new Trainer() { FirstName = "George", LastName = "Gkoskos", Age = 25, Subject = "C++" };
            Trainer t15 = new Trainer() { FirstName = "Panagiotis", LastName = "Gogos", Age = 32, Subject = "Cobol" };
            Trainer t16 = new Trainer() { FirstName = "Christos", LastName = "Soutis", Age = 31, Subject = "Python" };
            Trainer t17 = new Trainer() { FirstName = "Petros", LastName = "Lolos", Age = 34, Subject = "C++" };
            Trainer t18 = new Trainer() { FirstName = "Sotiris", LastName = "Krommidas", Age = 45, Subject = "Javascript" };
            Trainer t19 = new Trainer() { FirstName = "Nikos", LastName = "Simos", Age = 35, Subject = "JQ" };
            Trainer t20 = new Trainer() { FirstName = "Stella", LastName = "Fokoy", Age = 63, Subject = "Javascript" };
            Trainer t21 = new Trainer() { FirstName = "Jenny", LastName = "Sotoy", Age = 45, Subject = "C#" };
            Trainer t22 = new Trainer() { FirstName = "Lampros", LastName = "Lamprou", Age = 45, Subject = "Cobol" };
            Trainer t23 = new Trainer() { FirstName = "Kostas", LastName = "Kronis", Age = 56, Subject = "Javascript" };
            Trainer t24 = new Trainer() { FirstName = "Joan", LastName = "Soahn", Age = 38, Subject = "C++" };
            Trainer t25 = new Trainer() { FirstName = "Ioanna", LastName = "Barouta", Age = 32, Subject = "C#" };
            Trainer t26 = new Trainer() { FirstName = "Fainia", LastName = "Kim", Age = 36, Subject = "Javascript" };
            Trainer t27 = new Trainer() { FirstName = "Petros", LastName = "Krokso", Age = 56, Subject = "Cobol" };
            Trainer t28 = new Trainer() { FirstName = "Dimitra", LastName = "Fainou", Age = 42, Subject = "Javascript" };
            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28 };
            db.Trainers.AddRange(trainers);
            db.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
