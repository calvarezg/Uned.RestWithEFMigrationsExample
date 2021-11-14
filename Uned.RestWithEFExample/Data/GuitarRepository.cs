using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Data
{
    public class GuitarRepository
    {
        private ApplicationDataContext db;
        

        public GuitarRepository(ApplicationDataContext context)
        {
            this.db = context;
        }

        public Guitar Add(Guitar guitar)
        {
            guitar.History.Clear();
            guitar.History.Add(new GuitarHistory(HistoryType.Created));
            db.Guitars.Add(guitar);
            db.SaveChanges();
            return guitar;
        }

        internal IEnumerable<Guitar> ToList()
        {
            return db.Guitars.Where(g => g.IsActive).ToList();
        }

        internal Guitar Find(int id)
        {
            return db.Guitars
                .Include(g => g.History)
                .Where(g => g.Id.Equals(id) && g.IsActive)
                .FirstOrDefault();
        }

        internal void Update(Guitar guitar)
        {
            var history = new GuitarHistory(HistoryType.Modified);
            guitar.History.Add(history);
            db.Guitars.Update(guitar);
            db.SaveChanges();
        }

        internal bool NotExists(int id)
        {
            return !db.Guitars.Any(g => g.Id.Equals(id));
        }

        internal void Delete(int id)
        {
            var guitar = Find(id);
            guitar.IsActive = false;
            var history = new GuitarHistory(HistoryType.Deleted);
            guitar.History.Add(history);
            db.Guitars.Update(guitar);
            db.SaveChanges();
        }
    }
}
