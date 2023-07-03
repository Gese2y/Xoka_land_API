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
    public class View_Job_Assignment_transactionController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Job_Assignment_transactionController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Woreda}/{Job_Opportunity_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Woreda,Guid Job_Opportunity_ID)
        {
            var vm = _context.View_Job_Assignment_transaction.Where(x => x.Woreda == Woreda && x.Job_Opportunity_ID== Job_Opportunity_ID).ToList();
            return Ok(vm);
        }

    }
}
