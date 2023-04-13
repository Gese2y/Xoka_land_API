using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_Application_JsonController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Application_JsonController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{application_code}/{tasks_task_code}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(System.Guid application_code, System.Guid tasks_task_code)
        {
            var vm = _context.View_Application_Json.Where(x => x.application_code == application_code &&  x.tasks_task_code == tasks_task_code).ToList();
            return Ok(vm);
        }

    }
}
