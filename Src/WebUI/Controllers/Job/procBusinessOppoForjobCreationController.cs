using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationDelete.procBusinessOppoForjobCreationDeleteCommand;
using Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationInsert.procBusinessOppoForjobCreationInsertCommand;
using Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationUpdate.procBusinessOppoForjobCreationUpdateCommand;
using Application.Job.Quiries.procBusinessOppoForjobCreation;
using Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationByPrimaryKey;
using Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procBusinessOppoForjobCreationController:BaseController
    {
        private readonly ILogger logger;
        public procBusinessOppoForjobCreationController(ILogger<procBusinessOppoForjobCreationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocBusinessOppoForjobCreationLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{BUS_OPP_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocBusinessOppoForjobCreationLoadAllVm>> Get(Guid BUS_OPP_ID)
        {
            var vm = await Mediator.Send(new GetprocBusinessOppoForjobCreationByPrimaryKey { BUS_OPP_ID = BUS_OPP_ID });

            return Ok(vm);
        }

        [HttpDelete("{BUS_OPP_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid BUS_OPP_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procBusinessOppoForjobCreationDeleteCommand { BUS_OPP_ID = BUS_OPP_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].BUS_OPP_ID;

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
        public async Task<IActionResult> Create([FromBody]procBusinessOppoForjobCreationInsertCommand command)
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

                var id = vm[0].BUS_OPP_ID;

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
        public async Task<IActionResult> Update([FromBody]procBusinessOppoForjobCreationUpdateCommand command)
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
                var id = vm[0].BUS_OPP_ID;
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
