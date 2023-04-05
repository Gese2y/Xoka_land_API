using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procJob_Opportunity.procJob_OpportunityDelete.procJob_OpportunityDeleteCommand;
using Application.Job.Commands.procJob_Opportunity.procJob_OpportunityInsert.procJob_OpportunityInsertCommand;
using Application.Job.Commands.procJob_Opportunity.procJob_OpportunityUpdate.procJob_OpportunityUpdateCommand;
using Application.Job.Quiries.procJob_Opportunity;
using Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityByPrimaryKey;
using Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityLoadAll;
using Microsoft.Extensions.Logging;
namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procJob_OpportunityController : BaseController
    {
        private readonly ILogger logger;
        public procJob_OpportunityController(ILogger<procJob_OpportunityController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocJob_OpportunityLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Job_Opportunity_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocJob_OpportunityLoadAllVm>> Get(Guid Job_Opportunity_ID)
        {
            var vm = await Mediator.Send(new GetprocJob_OpportunityByPrimaryKey { Job_Opportunity_ID = Job_Opportunity_ID });

            return Ok(vm);
        }



        [HttpDelete("{Job_Opportunity_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Job_Opportunity_ID)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procJob_OpportunityDeleteCommand { Job_Opportunity_ID = Job_Opportunity_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Job_Opportunity_ID;

                if (id.ToString() == null)
                {
                    this.logger.LogInformation("delete faild");
                    return BadRequest("something went wrong");
                }
                else
                {
                    this.logger.LogInformation("value deleted: " + Newtonsoft.Json.JsonConvert.SerializeObject(vm));
                    return Ok(vm);
                }

            }
            catch (Exception ex)
            {
                this.logger.LogInformation("delete error: " + ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody] procJob_OpportunityInsertCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(command);
                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("insert: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Job_Opportunity_ID;

                if (id.ToString() == null)
                {
                    this.logger.LogInformation("insert faild");
                    return BadRequest("something went wrong");
                }
                else
                {
                    this.logger.LogInformation("value inserted: " + Newtonsoft.Json.JsonConvert.SerializeObject(vm));
                    return Ok(vm);
                }

            }
            catch (Exception ex)
            {
                this.logger.LogInformation("insert error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Update([FromBody] procJob_OpportunityUpdateCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(command);
                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("update: something went wrong");
                    return BadRequest("something went wrong");
                }
                var id = vm[0].Job_Opportunity_ID;
                if (id.ToString() == null)
                {
                    this.logger.LogInformation("update faild");
                    return BadRequest("something went wrong");
                }
                else
                {
                    this.logger.LogInformation("value updated: " + Newtonsoft.Json.JsonConvert.SerializeObject(vm));
                    return Ok(vm);
                }
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("update error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
