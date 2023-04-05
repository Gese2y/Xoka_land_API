using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.OCAC.Commands.procStandardExamReq.procStandardExamReqDelete.procStandardExamReqDeleteCommand;
using Application.OCAC.Commands.procStandardExamReq.procStandardExamReqInsert.procStandardExamReqInsertCommand;
using Application.OCAC.Commands.procStandardExamReq.procStandardExamReqUpdate.procStandardExamReqUpdateCommand;
using Application.OCAC.Quiries.procStandardExamReq;
using Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqByPrimaryKey;
using Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/OCAC/[controller]")]
    [ApiController]
    public class procStandardExamReqController:BaseController
    {
        private readonly ILogger logger;
        public procStandardExamReqController(ILogger<procStandardExamReqController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocStandardExamReqLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{OS_ID}/{OCAC_Exam}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocStandardExamReqLoadAllVm>> Get(string OS_ID, string OCAC_Exam)
        {
            var vm = await Mediator.Send(new GetprocStandardExamReqByPrimaryKey { OS_ID = OS_ID, OCAC_Exam = OCAC_Exam });

            return Ok(vm);
        }

        [HttpDelete("{OS_ID}/{OCAC_Exam}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string OS_ID, string OCAC_Exam)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procStandardExamReqDeleteCommand { OS_ID = OS_ID, OCAC_Exam = OCAC_Exam });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id_1 = vm[0].OS_ID;
                var id_2 = vm[0].OCAC_Exam;

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
        public async Task<IActionResult> Create([FromBody]procStandardExamReqInsertCommand command)
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

                var id_1 = vm[0].OS_ID;
                var id_2 = vm[0].OCAC_Exam;

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
        public async Task<IActionResult> Update([FromBody]procStandardExamReqUpdateCommand command)
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

                var id_1 = vm[0].OS_ID;
                var id_2 = vm[0].OCAC_Exam;

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
