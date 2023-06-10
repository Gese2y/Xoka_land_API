using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class view_Null_parent_job_positiontController : BaseController
    {

        private readonly XOKADbContext _context;
        public view_Null_parent_job_positiontController(XOKADbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = _context.view_Null_parent_job_position.ToList();
            return Ok(vm);
        }

    }
}
