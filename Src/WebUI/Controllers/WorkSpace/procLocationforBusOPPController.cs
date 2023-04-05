using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPDelete.procLocationforBusOPPDeleteCommand;
using Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPInsert.procLocationforBusOPPInsertCommand;
using Application.WorkSpace.Commands.procLocationforBusOPP.procLocationforBusOPPUpdate.procLocationforBusOPPUpdateCommand;
using Application.WorkSpace.Quiries.procLocationforBusOPP;
using Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPByPrimaryKey;
using Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/WorkSpace/[controller]")]
    [ApiController]
    public class procLocationforBusOPPController:BaseController
    {
        private readonly ILogger logger;
        public procLocationforBusOPPController(ILogger<procLocationforBusOPPController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocLocationforBusOPPLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{BUS_OPP_Loc_Code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocLocationforBusOPPLoadAllVm>> Get(Guid BUS_OPP_Loc_Code)
        {
            var vm = await Mediator.Send(new GetprocLocationforBusOPPByPrimaryKey { BUS_OPP_Loc_Code = BUS_OPP_Loc_Code });

            return Ok(vm);
        }

        [HttpDelete("{BUS_OPP_Loc_Code}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid BUS_OPP_Loc_Code)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procLocationforBusOPPDeleteCommand { BUS_OPP_Loc_Code = BUS_OPP_Loc_Code });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].BUS_OPP_Loc_Code;

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
        public async Task<IActionResult> Create([FromBody]procLocationforBusOPPInsertCommand command)
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

                var id = vm[0].BUS_OPP_Loc_Code;

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
        public async Task<IActionResult> Update([FromBody]procLocationforBusOPPUpdateCommand command)
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
                var id = vm[0].BUS_OPP_Loc_Code;
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
