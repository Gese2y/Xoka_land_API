using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Tax.Commands.procShareHolderDetail.procShareHolderDetailDelete.procShareHolderDetailDeleteCommand;
using Application.Tax.Commands.procShareHolderDetail.procShareHolderDetailInsert.procShareHolderDetailInsertCommand;
using Application.Tax.Commands.procShareHolderDetail.procShareHolderDetailUpdate.procShareHolderDetailUpdateCommand;
using Application.Tax.Quiries.procShareHolderDetail;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailByPrimaryKey;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAll;
using Microsoft.Extensions.Logging;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailviewByPrimaryKey;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Tax/[controller]")]
    [ApiController]
    public class procShareHolderDetailController:BaseController
    {
        private readonly ILogger logger;
        public procShareHolderDetailController(ILogger<procShareHolderDetailController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocShareHolderDetailLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocShareHolderDetailLoadAllVm>> Get(Guid ID)
        {
            var vm = await Mediator.Send(new GetprocShareHolderDetailByPrimaryKey { ID = ID });

            return Ok(vm);
        }
        [HttpGet("api/Tax{Licence_Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocShareHolderDetailLoadAllviewVm>> Getview(Guid Licence_Id)
        {
            var vm = await Mediator.Send(new GetprocShareHolderDetailviewByPrimaryKey { Licence_Id = Licence_Id });

            return Ok(vm);
        }
        [HttpDelete("{ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procShareHolderDetailDeleteCommand { ID = ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].ID;

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
        public async Task<IActionResult> Create([FromBody]procShareHolderDetailInsertCommand command)
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

                var id = vm[0].ID;

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
        public async Task<IActionResult> Update([FromBody] procShareHolderDetailUpdateCommand command)
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
                var id = vm[0].ID;
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
