using ProjectAssignment.Models;
using ProjectAssignment.MyDataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectAssignment.RepositoryService
{
    public class TrainerRepository
    {
        private AppDbContext db;

        public TrainerRepository(AppDbContext MyContext)
        {
           db = MyContext;
        }

        public IEnumerable<Trainer> GetAll()
        {
            return db.Trainers.ToList();
        }
        public Trainer Get(int? id)
        {
            return db.Trainers.Find(id);
        }
        public void Add (Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Added;
            db.SaveChanges();
        }
        public void Edit(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Trainer trainer = Get(id);
            db.Entry(trainer).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}