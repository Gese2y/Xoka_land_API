using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_woreda_for_SuportingServiceController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_woreda_for_SuportingServiceController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Kebele_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string Kebele_ID)
        {
            var vm = _context.View_woreda_for_SuportingService.Where(x => x.Kebele_ID == Kebele_ID).ToList();
            return Ok(vm);
        }

    }
}
