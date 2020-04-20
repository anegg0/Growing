using Growing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.Interfaces
{
    public interface ITrayType
    {
        public IEnumerable<TrayType> GetAllTrayTypes();
        public void AddTrayType(TrayType traytype);
        public void UpdateTrayType(TrayType traytype);
        public TrayType GetTrayTypeData(int id);
        public void DeleteTrayType(int id);
    }
}
