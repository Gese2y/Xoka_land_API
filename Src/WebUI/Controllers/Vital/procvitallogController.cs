using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;


using Application.Vital.Quiries.procvitallog.GetprocvitallogByPrimaryKey;

using Application.Vital.Quiries.procvitallog.GetprocvitallogLoadAll;
using Microsoft.Extensions.Logging;
using Application.Vital.Quiries.procvitallog;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Vital/[controller]")]
    [ApiController]
    public class procvitallogController : BaseController
    {
        private readonly ILogger logger;
        public procvitallogController(ILogger<procvitallogController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocvitallogLoadAllQuery() { });
            return Ok(vm);
        }

        [HttpGet("{Kebele_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocvitallogLoadAllVm>> Get(string Kebele_ID)
        {
            var vm = await Mediator.Send(new GetprocvitallogByPrimaryKey { Kebele_ID = Kebele_ID });

            return Ok(vm);
        }

    

    }
}
