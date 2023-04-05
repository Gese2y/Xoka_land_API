using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.OCAC.Commands.procExamResult.procExamResultDelete.procExamResultDeleteCommand;
using Application.OCAC.Commands.procExamResult.procExamResultInsert.procExamResultInsertCommand;
using Application.OCAC.Commands.procExamResult.procExamResultUpdate.procExamResultUpdateCommand;
using Application.OCAC.Quiries.procExamResult;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultByPrimaryKey;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadByPrimaryKeyOCACExamCadID;
using Application.OCAC.Quiries.procExamResult.GetprocExamResultLoadAll;
using Microsoft.Extensions.Logging;
using Application.OCAC.Quiries.procView_Exam_Result.GetprocView_Exam_ResultByPrimaryKey;
using Application.OCAC.Quiries.procView_Exam_Result;

namespace XOKA.WebUI.Controllers
{
    [Route("api/OCAC/[controller]")]
    [ApiController]
    public class procExamResultController:BaseController
    {
        private readonly ILogger logger;
        public procExamResultController(ILogger<procExamResultController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocExamResultLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocExamResultLoadAllVm>> Get(Guid ID)
        {
            var vm = await Mediator.Send(new GetprocExamResultByPrimaryKey { ID = ID });

            return Ok(vm);
        }  [HttpGet("View_Exam_Result/LicenceId/{Licence_Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocView_Exam_ResultLoadAllVm>> Getbylicence(Guid Licence_Id)
        {
            var vm = await Mediator.Send(new GetprocView_Exam_ResultByPrimaryKey { Licence_Id = Licence_Id });

            return Ok(vm);
        }

        [HttpGet("OCACExamCadID/{OCAC_Exam_Cad_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocExamResultLoadAllVm>> GetByOCACExamCadID(Guid OCAC_Exam_Cad_ID)
        {
            var vm = await Mediator.Send(new GetprocExamResultLoadByPrimaryKeyOCACExamCadID { OCAC_Exam_Cad_ID = OCAC_Exam_Cad_ID });

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

                var vm = await Mediator.Send(new procExamResultDeleteCommand { ID = ID });

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
        public async Task<IActionResult> Create([FromBody]procExamResultInsertCommand command)
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
        public async Task<IActionResult> Update([FromBody]procExamResultUpdateCommand command)
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
