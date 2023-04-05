using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceDelete.procEnterpriseApplicationForWorkspaceDeleteCommand;
using Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceInsert.procEnterpriseApplicationForWorkspaceInsertCommand;
using Application.WorkSpace.Commands.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceUpdate.procEnterpriseApplicationForWorkspaceUpdateCommand;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceByPrimaryKey;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.procEnterpriseApplicationForWorkspaceLoadByPrimaryKeyTIN;
using Application.WorkSpace.Quiries.procEnterpriseApplicationForWorkspace.GetprocEnterpriseApplicationForWorkspaceLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/WorkSpace/[controller]")]
    [ApiController]
    public class procEnterpriseApplicationForWorkspaceController:BaseController
    {
        private readonly ILogger logger;
        public procEnterpriseApplicationForWorkspaceController(ILogger<procEnterpriseApplicationForWorkspaceController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocEnterpriseApplicationForWorkspaceLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{EAFW_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseApplicationForWorkspaceLoadAllVm>> Get(Guid EAFW_ID)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseApplicationForWorkspaceByPrimaryKey { EAFW_ID = EAFW_ID });

            return Ok(vm);
        }

        [HttpGet("TIN/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseApplicationForWorkspaceLoadAllVm>> GetByTIN(string TIN)
        {
            var vm = await Mediator.Send(new procEnterpriseApplicationForWorkspaceLoadByPrimaryKeyTIN { TIN = TIN });

            return Ok(vm);
        }

        [HttpDelete("{EAFW_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid EAFW_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procEnterpriseApplicationForWorkspaceDeleteCommand { EAFW_ID = EAFW_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].EAFW_ID;

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
        public async Task<IActionResult> Create([FromBody]procEnterpriseApplicationForWorkspaceInsertCommand command)
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

                var id = vm[0].EAFW_ID;

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
        public async Task<IActionResult> Update([FromBody]procEnterpriseApplicationForWorkspaceUpdateCommand command)
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
                var id = vm[0].EAFW_ID;
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
