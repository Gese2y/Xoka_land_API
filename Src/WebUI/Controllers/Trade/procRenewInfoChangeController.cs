using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeDelete.procRenewInfoChangeDeleteCommand;
using Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeInsert.procRenewInfoChangeInsertCommand;
using Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeUpdate.procRenewInfoChangeUpdateCommand;
using Application.Trade.Quiries.procRenewInfoChange;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeByPrimaryKey;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadByPrimaryKeyID;
using Application.Trade.Quiries.procRenewInfoChange.GetprocRenewInfoChangeLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Trade/[controller]")]
    [ApiController]
    public class procRenewInfoChangeController:BaseController
    {
        private readonly ILogger logger;
        public procRenewInfoChangeController(ILogger<procRenewInfoChangeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocRenewInfoChangeLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Change_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocRenewInfoChangeLoadAllVm>> Get(Guid Change_ID)
        {
            var vm = await Mediator.Send(new GetprocRenewInfoChangeByPrimaryKey { Change_ID = Change_ID });

            return Ok(vm);
        }

        [HttpGet("ID/{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocRenewInfoChangeLoadAllVm>> GetById(string ID)
        {
            var vm = await Mediator.Send(new GetprocRenewInfoChangeLoadByPrimaryKeyID { ID = ID });

            return Ok(vm);
        }

        [HttpDelete("{Change_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Change_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procRenewInfoChangeDeleteCommand { Change_ID = Change_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Change_ID;

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
        public async Task<IActionResult> Create([FromBody]procRenewInfoChangeInsertCommand command)
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

                var id = vm[0].Change_ID;

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
        public async Task<IActionResult> Update([FromBody]procRenewInfoChangeUpdateCommand command)
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
                var id = vm[0].Change_ID;
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
