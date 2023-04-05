using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_Unemployment_Education_ExperienceController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Unemployment_Education_ExperienceController(XOKADbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = _context.View_Unemployment_Education_Experience.ToList();
            return Ok(vm);
        }

    }
}
