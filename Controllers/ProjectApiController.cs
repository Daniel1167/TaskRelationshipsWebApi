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
    public class ProjectApiController : ControllerBase
    {
         private readonly DataContext dbContext;
        public ProjectApiController(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var allProjects = dbContext.Projects.ToList();
            return Ok(allProjects);
        }
    }
}