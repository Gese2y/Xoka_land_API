using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_appliction_by_usernameController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_appliction_by_usernameController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{UserName}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string UserName)
        {
            var vm = _context.View_appliction_by_username.Where(x => x.UserName == UserName).ToList();
            return Ok(vm);
        }

    }
}
