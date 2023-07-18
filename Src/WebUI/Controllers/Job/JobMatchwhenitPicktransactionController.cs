using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;


using Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction;
using Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionByPrimaryKey;

using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class JobMatchwhenitPicktransactionController : BaseController
    {
        private readonly ILogger logger;
        public JobMatchwhenitPicktransactionController(ILogger<Job_procMarketOPPController> logger)
        {
            this.logger = logger;
        }

      

        [HttpGet("{Transaction_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<JobMatchwhenitPicktransactionLoadAllVm>> Get(Guid Transaction_ID)
        {
            var vm = await Mediator.Send(new JobMatchwhenitPicktransactionByPrimaryKey { Transaction_ID = Transaction_ID });

            return Ok(vm);
        }

     
    }
}
