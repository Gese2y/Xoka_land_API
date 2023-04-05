using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class ViewWorkinfoController : BaseController
    {

        private readonly XOKADbContext _context;
        public ViewWorkinfoController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{UserName}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string UserName)
        {
            var vm = _context.ViewWorkinfo.Where(x => x.UserName == UserName).ToList();
            return Ok(vm);
        }

    }
}
