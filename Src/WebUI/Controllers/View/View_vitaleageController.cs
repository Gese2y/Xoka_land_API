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
    public class View_vitaleageController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_vitaleageController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string ID)
        {
            var vm = _context.View_vitaleage.Where(x => x.ID == ID).ToList();
            return Ok(vm);
        }

    }
}
