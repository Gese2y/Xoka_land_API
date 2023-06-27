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
    public class View_shareholderdetailbydartController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_shareholderdetailbydartController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{DAR_NO}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string DAR_NO)
        {
            var vm = _context.View_shareholderdetailbydar.Where(x => x.DAR_NO == DAR_NO).ToList();
            return Ok(vm);
        }

    }
}
