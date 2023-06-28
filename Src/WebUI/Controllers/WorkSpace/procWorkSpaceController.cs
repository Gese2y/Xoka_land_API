using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceDelete.procWorkSpaceDeleteCommand;
using Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceInsert.procWorkSpaceInsertCommand;
using Application.WorkSpace.Commands.procWorkSpace.procWorkSpaceUpdate.procWorkSpaceUpdateCommand;
using Application.WorkSpace.Quiries.procWorkSpace;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceByPrimaryKey;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceByparentKey;
using Application.WorkSpace.Quiries.procWorkSpace.GetprocWorkSpaceLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/WorkSpace/[controller]")]
    [ApiController]
    public class procWorkSpaceController:BaseController
    {
        private readonly ILogger logger;
        public procWorkSpaceController(ILogger<procWorkSpaceController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocWorkSpaceLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Work_Space_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocWorkSpaceLoadAllVm>> Get(Guid Work_Space_ID)
        {
            var vm = await Mediator.Send(new GetprocWorkSpaceByPrimaryKey { Work_Space_ID = Work_Space_ID });

            return Ok(vm);
        }

        [HttpGet("parent/{Work_Space_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocWorkSpaceLoadAllVm>> Getparent(Guid Work_Space_ID)
        {
            var vm = await Mediator.Send(new GetprocWorkSpaceByParentKey { Work_Space_ID = Work_Space_ID });

            return Ok(vm);
        }

        [HttpDelete("{Work_Space_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Work_Space_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procWorkSpaceDeleteCommand { Work_Space_ID = Work_Space_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Work_Space_ID;

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
        public async Task<IActionResult> Create([FromBody]procWorkSpaceInsertCommand command)
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

                var id = vm[0].Work_Space_ID;

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
        public async Task<IActionResult> Update([FromBody]procWorkSpaceUpdateCommand command)
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
                var id = vm[0].Work_Space_ID;
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
