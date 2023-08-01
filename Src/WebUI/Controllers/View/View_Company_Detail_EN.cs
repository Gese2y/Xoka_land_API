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
    public class View_Company_Detail_ENController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Company_Detail_ENController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{TIN}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string TIN)
        {
            var vm = _context.View_Company_Detail_EN.Where(x => x.TIN == TIN).ToList();
            return Ok(vm);
        }

    }
}
