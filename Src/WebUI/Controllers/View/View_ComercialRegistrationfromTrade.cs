using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_ComercialRegistrationfromTradeController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_ComercialRegistrationfromTradeController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Tin}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string Tin)
        {
            var vm = _context.View_ComercialRegistrationfromTrade.Where(x => x.Tin == Tin).ToList();
            return Ok(vm);
        }

    }
}
