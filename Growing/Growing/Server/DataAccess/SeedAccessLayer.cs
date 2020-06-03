using Growing.Server.Interfaces;
using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.DataAccess
{
    public class SeedDataAccessLayer: ISeed
    {
        SeedContext db = new SeedContext();

        //To Get all seeds details   
        public IEnumerable<Seed> GetAllSeeds()
        {
            try
            {
                return db.tblSeed.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new seed record     
        public void AddSeed(Seed seed)
        {
            try
            {
                db.tblSeed.Add(seed);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar seed    
        public void UpdateSeed(Seed seed)
        {
            try
            {
                db.Entry(seed).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular seed    
        public Seed GetSeedData(int id)
        {
            try
            {
                Seed seed = db.tblSeed.Find(id);
                return seed;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular seed    
        public void DeleteSeed(int id)
        {
            try
            {
                Seed seed = db.tblSeed.Find(id);
                db.tblSeed.Remove(seed);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
