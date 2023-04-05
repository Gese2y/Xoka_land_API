using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForDelete.procCoCApplayExamForDeleteCommand;
using Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForInsert.procCoCApplayExamForInsertCommand;
using Application.OCAC.Commands.procCoCApplayExamFor.procCoCApplayExamForUpdate.procCoCApplayExamForUpdateCommand;
using Application.OCAC.Quiries.procCoCApplayExamFor;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForByPrimaryKey;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/OCAC/[controller]")]
    [ApiController]
    public class procCoCApplayExamForController:BaseController
    {
        private readonly ILogger logger;
        public procCoCApplayExamForController(ILogger<procCoCApplayExamForController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocCoCApplayExamForLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCoCApplayExamForLoadAllVm>> Get(Guid Id)
        {
            var vm = await Mediator.Send(new GetprocCoCApplayExamForByPrimaryKey { Id = Id });

            return Ok(vm);
        }

        [HttpGet("COCCandID/{COC_Cand_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCoCApplayExamForLoadAllVm>> GetByCOCCandID(Guid COC_Cand_ID)
        {
            var vm = await Mediator.Send(new GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID { COC_Cand_ID = COC_Cand_ID });

            return Ok(vm);
        }

        [HttpDelete("{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Id)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procCoCApplayExamForDeleteCommand { Id = Id });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Id;

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
        public async Task<IActionResult> Create([FromBody]procCoCApplayExamForInsertCommand command)
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

                var id = vm[0].Id;

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
        public async Task<IActionResult> Update([FromBody]procCoCApplayExamForUpdateCommand command)
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
                var id = vm[0].Id;
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
