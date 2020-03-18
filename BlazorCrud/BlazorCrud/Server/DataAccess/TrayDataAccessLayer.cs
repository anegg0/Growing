using Growing.Server.Interfaces;
using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.DataAccess
{
    public class TrayDataAccessLayer: ITray
    {
        TrayContext db = new TrayContext();

        //To Get all trays details   
        public IEnumerable<Tray> GetAllTrays()
        {
            try
            {
                return db.tblTray.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new tray record     
        public void AddTray(Tray tray)
        {
            try
            {
                db.tblTray.Add(tray);
                db.SaveChanges(); 
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar tray    
        public void UpdateTray(Tray tray)
        {
            try
            {
                db.Entry(tray).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular tray    
        public Tray GetTrayData(int id)
        {
            try
            {
                Tray tray = db.tblTray.Find(id);
                return tray;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular tray    
        public void DeleteTray(int id)
        {
            try
            {
                Tray tray = db.tblTray.Find(id);
                db.tblTray.Remove(tray);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
