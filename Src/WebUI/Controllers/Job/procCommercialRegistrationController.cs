using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationDelete.procCommercialRegistrationDeleteCommand;
using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationUpdate.procCommercialRegistrationUpdateCommand;
using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationInsert.procCommercialRegistrationInsertCommand;
using Application.Trade.Quiries.procCommercialRegistration;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationByPrimaryKey;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadByPrimaryKeyTIN;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procCommercialRegistrationController:BaseController
    {
        private readonly ILogger logger;
        public procCommercialRegistrationController(ILogger<Trade_procCommercialRegistrationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{COM_REG_Number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCommercialRegistrationLoadAllVm>> Get(string COM_REG_Number)
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationByPrimaryKey { COM_REG_Number = COM_REG_Number });

            return Ok(vm);
        }

        [HttpGet("TIN/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCommercialRegistrationLoadAllVm>> GetByTIN(long TIN)
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationLoadByPrimaryKeyTIN { TIN = TIN });

            return Ok(vm);
        }

        [HttpDelete("{COM_REG_Number}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string COM_REG_Number)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procCommercialRegistrationDeleteCommand { COM_REG_Number = COM_REG_Number });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].COM_REG_Number;

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
        public async Task<IActionResult> Create([FromBody] procCommercialRegistrationInsertCommand command)
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

                var id = vm[0].COM_REG_Number;

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
        public async Task<IActionResult> Update([FromBody] procCommercialRegistrationUpdateCommand command)
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
                var id = vm[0].COM_REG_Number;
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
