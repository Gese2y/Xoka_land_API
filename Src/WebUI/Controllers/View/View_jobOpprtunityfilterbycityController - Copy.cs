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
    public class view_opportunityapiController : BaseController
    {

        private readonly XOKADbContext _context;
        public view_opportunityapiController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Job_Opportunity_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Job_Opportunity_ID)
        {
            var vm = _context.view_opportunityapi.Where(x => x.Job_Opportunity_ID == Job_Opportunity_ID).ToList();
            return Ok(vm);
        }

    }
}
