using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetDelete.procMSEBalanceSheetDeleteCommand;
using Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetInsert.procMSEBalanceSheetInsertCommand;
using Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetUpdate.procMSEBalanceSheetUpdateCommand;
using Application.Job.Quiries.procMSEBalanceSheet;
using Application.Job.Quiries.procMSEBalanceSheet.GetprocMSEBalanceSheetByPrimaryKey;
using Application.Job.Quiries.procMSEBalanceSheet.GetprocMSEBalanceSheetLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procMSEBalanceSheetController:BaseController
    {
        private readonly ILogger logger;
        public procMSEBalanceSheetController(ILogger<procMSEBalanceSheetController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocMSEBalanceSheetLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Year}/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocMSEBalanceSheetLoadAllVm>> Get(int Year, string TIN)
        {
            var vm = await Mediator.Send(new GetprocMSEBalanceSheetByPrimaryKey { Year = Year, TIN = TIN });

            return Ok(vm);
        }

        [HttpDelete("{Year}/{TIN}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int Year, string TIN)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procMSEBalanceSheetDeleteCommand { Year = Year, TIN = TIN });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id_1 = vm[0].Year;
                var id_2 = vm[0].TIN;

                if ( id_1.ToString() == null || id_2.ToString() == null )
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
        public async Task<IActionResult> Create([FromBody]procMSEBalanceSheetInsertCommand command)
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

                var id_1 = vm[0].Year;
                var id_2 = vm[0].TIN;

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
        public async Task<IActionResult> Update([FromBody]procMSEBalanceSheetUpdateCommand command)
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

                var id_1 = vm[0].Year;
                var id_2 = vm[0].TIN;

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
