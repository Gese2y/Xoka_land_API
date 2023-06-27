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
    public class View_Job_MatchdesendingorderController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Job_MatchdesendingorderController(XOKADbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = _context.View_Job_Matchdesendingorder.ToList();
            return Ok(vm);
        }
        [HttpGet("{Transaction_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Transaction_ID)
        {
            var vm = _context.View_Job_Matchdesendingorder.Where(x => x.Transaction_ID == Transaction_ID).ToList();
            return Ok(vm);
        }

    }
}
