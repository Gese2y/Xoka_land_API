using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class ViewMKTProdIOController : BaseController
    {

        private readonly XOKADbContext _context;
        public ViewMKTProdIOController(XOKADbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = _context.ViewMKTProdIO.ToList();
            return Ok(vm);
        }

    }
}
