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
    public class TrayController : Controller
    {
        private readonly ITray objtray;

        public TrayController(ITray _objtray)
        {
            objtray = _objtray;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Tray> Index()
        {
            return objtray.GetAllTrays();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Tray tray)
        {
            if (ModelState.IsValid)
                objtray.AddTray(tray);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Tray Details(int id)
        {

            return objtray.GetTrayData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]Tray tray)
        {
            if (ModelState.IsValid)
                objtray.UpdateTray(tray);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objtray.DeleteTray(id);
        }
    }
}
