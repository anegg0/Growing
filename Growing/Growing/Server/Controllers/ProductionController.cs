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
    public class ProductionController : Controller
    {
        private readonly IProduction objproduction;

        public ProductionController(IProduction _objproduction)
        {
            objproduction = _objproduction;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Production> Index()
        {
            return objproduction.GetAllProductions();
        }

        [HttpPost]
        [Route("Create")]
        public void Create([FromBody] Production production)
        {
            if (ModelState.IsValid)
                objproduction.AddProduction(production);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public Production Details(int id)
        {

            return objproduction.GetProductionData(id);
        }

        [HttpPut]
        [Route("Edit")]
        public void Edit([FromBody]Production production)
        {
            if (ModelState.IsValid)
                objproduction.UpdateProduction(production);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            objproduction.DeleteProduction(id);
        }
    }
}
