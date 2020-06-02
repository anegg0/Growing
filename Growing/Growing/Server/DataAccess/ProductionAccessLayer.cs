using Growing.Server.Interfaces;
using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.DataAccess
{
    public class ProductionDataAccessLayer: IProduction
    {
        ProductionContext db = new ProductionContext();

        //To Get all productions details   
        public IEnumerable<Production> GetAllProductions()
        {
            try
            {
                return db.tblProduction.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new production record     
        public void AddProduction(Production production)
        {
            try
            {
                db.tblProduction.Add(production);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar production    
        public void UpdateProduction(Production production)
        {
            try
            {
                db.Entry(production).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular production    
        public Production GetProductionData(int id)
        {
            try
            {
                Production production = db.tblProduction.Find(id);
                return production;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular production    
        public void DeleteProduction(int id)
        {
            try
            {
                Production production = db.tblProduction.Find(id);
                db.tblProduction.Remove(production);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
