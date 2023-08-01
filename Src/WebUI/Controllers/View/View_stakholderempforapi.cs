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
    public class View_stakholderempforapiController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_stakholderempforapiController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Stakeholder_TIN}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string Stakeholder_TIN)
        {
            var vm = _context.View_stakholderempforapi.Where(x => x.Stakeholder_TIN == Stakeholder_TIN).ToList();
            return Ok(vm);
        } 
        [HttpGet("vitalid/{Kebele_ID}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Getbykebeleid(string Kebele_ID)
        {
            var vm = _context.View_stakholderempforapi.Where(x => x.Kebele_ID == Kebele_ID).ToList();
            return Ok(vm);
        }

    }
}
