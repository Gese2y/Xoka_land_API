using Microsoft.AspNetCore.Mvc;
using Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class view__job_positionbyparentController : BaseController
    {

        private readonly XOKADbContext _context;
        public view__job_positionbyparentController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Parent_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string Parent_ID)
        {
            var vm = _context.view__job_positionbyparent.Where(x => x.Parent_ID == Parent_ID).ToList();
            return Ok(vm);
        }

    }
}
