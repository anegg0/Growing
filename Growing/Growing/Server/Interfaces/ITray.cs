using Growing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.Interfaces
{
    public interface IProduction
    {
        public IEnumerable<Production> GetAllProductions();
        public void AddProduction(Production production);
        public void UpdateProduction(Production production);
        public Production GetProductionData(int id);
        public void DeleteProduction(int id);
    }
}
