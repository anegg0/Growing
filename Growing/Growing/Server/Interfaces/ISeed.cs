using Growing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Growing.Server.Interfaces
{
    public interface ISeed
    {
        public IEnumerable<Seed> GetAllSeeds();
        public void AddSeed(Seed seed);
        public void UpdateSeed(Seed seed);
        public Seed GetSeedData(int id);
        public void DeleteSeed(int id);
    }
}
