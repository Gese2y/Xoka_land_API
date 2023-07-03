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
    public class View_jobOpprtunityfilterbycityController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_jobOpprtunityfilterbycityController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Parent_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Sub_City, Guid Job_Opportunity_ID)
        {
            var vm = _context.View_jobOpprtunityfilterbycity.Where(x => x.Sub_City == Sub_City && x.Job_Opportunity_ID == Job_Opportunity_ID).ToList();
            return Ok(vm);
        }

    }
}
