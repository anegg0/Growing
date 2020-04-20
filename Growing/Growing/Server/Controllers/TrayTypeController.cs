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
    public class TrayTypeController : Controller
    {
        private readonly ITrayType objtraytype;

        public TrayTypeController(ITrayType _objtraytype)
        {
            objtraytype = _objtraytype;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<TrayType> Index()
        {
            return objtraytype.GetAllTrayTypes();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] TrayType trayType)
        {
            if (ModelState.IsValid)
                objtraytype.AddTrayType(trayType);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public TrayType Details(int id)
        {

            return objtraytype.GetTrayTypeData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]TrayType trayType)
        {
            if (ModelState.IsValid)
                objtraytype.UpdateTrayType(trayType);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objtraytype.DeleteTrayType(id);
        }
    }
}
