using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.SaveCredit.Commands.procInstalments.procInstalmentsDelete.procInstalmentsDeleteCommand;
using Application.SaveCredit.Commands.procInstalments.procInstalmentsInsert.procInstalmentsInsertCommand;
using Application.SaveCredit.Commands.procInstalments.procInstalmentsUpdate.procInstalmentsUpdateCommand;
using Application.SaveCredit.Quiries.procInstalments;
using Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsByPrimaryKey;
using Application.SaveCredit.Quiries.procInstalments.GetprocInstalmentsLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/SaveCredit/[controller]")]
    [ApiController]
    public class procInstalmentsController:BaseController
    {
        private readonly ILogger logger;
        public procInstalmentsController(ILogger<procInstalmentsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocInstalmentsLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{contract_id}/{number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocInstalmentsLoadAllVm>> Get(Guid contract_id, Int32 number)
        {
            var vm = await Mediator.Send(new GetprocInstalmentsByPrimaryKey { contract_id = contract_id, number = number });

            return Ok(vm);
        }

        [HttpDelete("{contract_id}/{number}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid contract_id, Int32 number)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procInstalmentsDeleteCommand { contract_id = contract_id, number = number });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id_1 = vm[0].contract_id;
                var id_2 = vm[0].number;

                if (id_1.ToString() == null || id_2.ToString() == null)
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
        public async Task<IActionResult> Create([FromBody]procInstalmentsInsertCommand command)
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

                var id_1 = vm[0].contract_id;
                var id_2 = vm[0].number;

                if (id_1.ToString() == null || id_2.ToString() == null)
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
        public async Task<IActionResult> Update([FromBody]procInstalmentsUpdateCommand command)
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

                var id_1 = vm[0].contract_id;
                var id_2 = vm[0].number;

                if (id_1.ToString() == null || id_2.ToString() == null)
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
