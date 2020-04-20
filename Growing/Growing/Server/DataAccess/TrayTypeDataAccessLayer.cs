using Growing.Server.Interfaces;
using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.DataAccess
{
    public class TrayTypeDataAccessLayer: ITrayType
    {
        TrayTypeContext db = new TrayTypeContext();

        //To Get all trays details   
        public IEnumerable<TrayType> GetAllTrayTypes()
        {
            try
            {
                return db.tblTrayType.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new tray record     
        public void AddTrayType(TrayType trayType)
        {
            try
            {
                db.tblTrayType.Add(trayType);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar tray    
        public void UpdateTrayType(TrayType trayType)
        {
            try
            {
                db.Entry(trayType).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular tray    
        public TrayType GetTrayTypeData(int id)
        {
            try
            {
                TrayType trayType = db.tblTrayType.Find(id);
                return trayType;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular tray    
        public void DeleteTrayType(int id)
        {
            try
            {
                TrayType trayType = db.tblTrayType.Find(id);
                db.tblTrayType.Remove(trayType);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
