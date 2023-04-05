using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;


using Application.UnEmployment.Quiries.procUnEmployeeInfo;
using Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoByPrimaryKey;
using Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoLoadAll;

using Microsoft.Extensions.Logging;


namespace XOKA.WebUI.Controllers
{
    [Route("api/UnEmployment/[controller]")]
    [ApiController]
    public class procUnEmployeeinfoController : BaseController
    {
        private readonly ILogger logger;
        public procUnEmployeeinfoController(ILogger<procUnEmployeeinfoController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var vm = await Mediator.Send(new GetprocUnEmployeeInfoLoadQuery() { });
            return Ok(vm);
        }

        [HttpGet("{Kebele_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocUnEmployeeInfoLoadAllVm>> Get(string Kebele_ID)
        {
            var vm = await Mediator.Send(new GetprocUnEmployeeInfoByPrimaryKey { Kebele_ID = Kebele_ID });

            return Ok(vm);
        }

        

    }
}
