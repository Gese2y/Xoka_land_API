using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.TVET.Commands.procTVETResult.procTVETResultDelete.procTVETResultDeleteCommand;
using Application.TVET.Commands.procTVETResult.procTVETResultInsert.procTVETResultInsertCommand;
using Application.TVET.Commands.procTVETResult.procTVETResultUpdate.procTVETResultUpdateCommand;
using Application.TVET.Quiries.procTVETResult;
using Application.TVET.Quiries.procView_TVET_Result_Pop_UP;
using Application.TVET.Quiries.procView_TVET_Result_Pop_UP.GetprocView_TVET_Result_Pop_UPByPrimaryKey;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultByPrimaryKey;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadByPrimaryKeyEID;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/TVET/[controller]")]
    [ApiController]
    public class procTVETResultController:BaseController
    {
        private readonly ILogger logger;
        public procTVETResultController(ILogger<procTVETResultController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocTVETResultLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{RId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocTVETResultLoadAllVm>> Get(Guid RId)
        {
            var vm = await Mediator.Send(new GetprocTVETResultByPrimaryKey { RId = RId });

            return Ok(vm);
        }

        [HttpGet("EID/{EID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocTVETResultLoadAllVm>> GetByEID(Guid EID)
        {
            var vm = await Mediator.Send(new GetprocTVETResultLoadByPrimaryKeyEID { EID = EID });

            return Ok(vm);
        }
        [HttpGet("api/TVET/EID/{EID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocView_TVET_Result_Pop_UPLoadAllVm>> GetVIEWByEID(Guid EID)
        {
            var vm = await Mediator.Send(new GetprocView_TVET_Result_Pop_UPByPrimaryKey { EID = EID });

            return Ok(vm);
        }

        [HttpDelete("{RId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid RId)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procTVETResultDeleteCommand { RId = RId });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].RId;

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
        public async Task<IActionResult> Create([FromBody]procTVETResultInsertCommand command)
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

                var id = vm[0].RId;

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
        public async Task<IActionResult> Update([FromBody]procTVETResultUpdateCommand command)
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
                var id = vm[0].RId;
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
