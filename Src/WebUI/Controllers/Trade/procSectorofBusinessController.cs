using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessDelete.procSectorofBusinessDeleteCommand;
using Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessInsert.procSectorofBusinessInsertCommand;
using Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessUpdate.procSectorofBusinessUpdateCommand;
using Application.Trade.Quiries.procSectorofBusiness;
using Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessByPrimaryKey;
using Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Trade/[controller]")]
    [ApiController]
    public class procSectorofBusinessController:BaseController
    {
        private readonly ILogger logger;
        public procSectorofBusinessController(ILogger<procSectorofBusinessController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocSectorofBusinessLoadAllQuery() { });

            return Ok(vm);
        }


        [HttpGet("{TIN}/{Code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocSectorofBusinessLoadAllVm>> Get(string TIN, string Code)
        {
            var vm = await Mediator.Send(new GetprocSectorofBusinessByPrimaryKey { TIN = TIN, Code = Code });

            return Ok(vm);
        }

        [HttpDelete("{TIN}/{Code}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string TIN, string Code)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procSectorofBusinessDeleteCommand { TIN = TIN, Code = Code });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id_1 = vm[0].TIN;
                var id_2 = vm[0].Code;

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
        public async Task<IActionResult> Create([FromBody]procSectorofBusinessInsertCommand command)
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

                var id_1 = vm[0].TIN;
                var id_2 = vm[0].Code;

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
        public async Task<IActionResult> Update([FromBody]procSectorofBusinessUpdateCommand command)
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

                var id_1 = vm[0].TIN;
                var id_2 = vm[0].Code;

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
