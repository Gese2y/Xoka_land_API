using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsDelete.procEnterpriseGradeRenewalDetailsDeleteCommand;
using Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsInsert.procEnterpriseGradeRenewalDetailsInsertCommand;
using Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsUpdate.procEnterpriseGradeRenewalDetailsUpdateCommand;
using Application.Job.Quiries.procEnterpriseGradeRenewal;
using Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalByPrimaryKey;
using Application.Job.Quiries.procEnterpriseGradeRenewal.GetprocEnterpriseGradeRenewalLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procEnterpriseGradeRenewalController : BaseController
    {
        private readonly ILogger logger;
        public procEnterpriseGradeRenewalController(ILogger<procEnterpriseGradeRenewalController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocEnterpriseGradeRenewalLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Ent_Grading_Detail_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseGradeRenewalLoadAllVm>> Get(Guid Ent_Grading_Detail_ID)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseGradeRenewalByPrimaryKey { Ent_Grading_Detail_ID = Ent_Grading_Detail_ID });

            return Ok(vm);
        }

        [HttpDelete("{Ent_Grading_Detail_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Ent_Grading_Detail_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procEnterpriseGradeRenewalDetailsDeleteCommand { Ent_Grading_Detail_ID = Ent_Grading_Detail_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Ent_Grading_Detail_ID;

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
        public async Task<IActionResult> Create([FromBody]procEnterpriseGradeRenewalDetailsInsertCommand command)
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

                var id = vm[0].Ent_Grading_Detail_ID;

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
        public async Task<IActionResult> Update([FromBody]procEnterpriseGradeRenewalDetailsUpdateCommand command)
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
                var id = vm[0].Ent_Grading_Detail_ID;
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
