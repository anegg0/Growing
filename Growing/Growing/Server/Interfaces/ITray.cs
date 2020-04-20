using Growing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.Interfaces
{
    public interface ITray
    {
        public IEnumerable<Tray> GetAllTrays();
        public void AddTray(Tray tray);
        public void UpdateTray(Tray tray);
        public Tray GetTrayData(int id);
        public void DeleteTray(int id);
    }
}