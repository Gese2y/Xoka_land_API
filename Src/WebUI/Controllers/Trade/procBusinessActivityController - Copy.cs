using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procSector.procSectorDelete.procSectorDeleteCommand;
using Application.Trade.Commands.procSector.procSectorInsert.procSectorInsertCommand;
using Application.Trade.Commands.procSector.procSectorUpdate.procSectorUpdateCommand;
using Application.Trade.Quiries.procSector;
using Application.Trade.Quiries.procSector.GetprocSectorByPrimaryKey;
using Application.Trade.Quiries.procSector.GetprocSectorLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Trade/[controller]")]
    [ApiController]
    public class procSectorController:BaseController
    {
        private readonly ILogger logger;
        public procSectorController(ILogger<procSectorController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocSectorLoadAllQuery() { });

            return Ok(vm);
        }


        [HttpGet("parent")]
        public async Task<IActionResult> GetAllParent()
        {
            var vm = await Mediator.Send(new GetprocSectorLoadAllQuery() { });
            var v = vm.procSectors.Where(e => e.Parent == null);

            return Ok(v);
        }
        [HttpGet("parent/{paretn_id}")]
        public async Task<IActionResult> GetAllParentId(string paretn_id)
        {
            var vm = await Mediator.Send(new GetprocSectorLoadAllQuery() { });
            var v = vm.procSectors.Where(e => e.Parent == paretn_id);

            return Ok(v);
        }
        [HttpGet("CBC/{cbc_id}")]
        public async Task<IActionResult> GetAllCBCId(string cbc_id)
        {
            var vm = await Mediator.Send(new GetprocSectorLoadAllQuery() { });
            var v = vm.procSectors.Where(e => e.Comm_Bus_Code == cbc_id);

            return Ok(v);
        }

        [HttpGet("{S_Code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocSectorLoadAllVm>> GetParetn(string S_Code)
        {
            var vm = await Mediator.Send(new GetprocSectorByPrimaryKey { S_Code = S_Code });

            return Ok(vm);
        }
       

        [HttpDelete("{S_Code}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string S_Code)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procSectorDeleteCommand { S_Code = S_Code });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].S_Code;

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
        public async Task<IActionResult> Create([FromBody]procSectorInsertCommand command)
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

                var id = vm[0].S_Code;

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
        public async Task<IActionResult> Update([FromBody]procSectorUpdateCommand command)
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
                var id = vm[0].S_Code;
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
