using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelationshipEnitites.Data;

namespace RelationshipEnitites.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyApiController : ControllerBase
    {
         private readonly DataContext dbContext;
        public CompanyApiController(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllCompanies()
        {
            var allCompanies = dbContext.Companies.ToList();
            return Ok(allCompanies);
        }
    }
}