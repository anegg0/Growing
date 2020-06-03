using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Growing.Server.Interfaces;
using Growing.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Growing.Server.Controllers
{
    [Route("api/[controller]")]
    public class SeedController : Controller
    {
        private readonly ISeed objseed;

        public SeedController(ISeed _objseed)
        {
            objseed = _objseed;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Seed> Index()
        {
            return objseed.GetAllSeeds();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Seed seed)
        {
            if (ModelState.IsValid)
                objseed.AddSeed(seed);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Seed Details(int id)
        {

            return objseed.GetSeedData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]Seed seed)
        {
            if (ModelState.IsValid)
                objseed.UpdateSeed(seed);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objseed.DeleteSeed(id);
        }
    }
}
