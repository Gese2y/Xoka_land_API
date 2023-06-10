using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_Apliction_by_username_and_serviceController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Apliction_by_username_and_serviceController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{UserName}/{services_service_code}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string UserName, System.Guid services_service_code)
        {
            var vm = _context.View_Apliction_by_username_and_service.Where(x => x.UserName == UserName && x.services_service_code== services_service_code).ToList();
            return Ok(vm);
        }

    }
}
