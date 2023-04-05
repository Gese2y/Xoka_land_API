using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationDelete.procEnterpriseRegistrationDeleteCommand;
using Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationInsert.procEnterpriseRegistrationInsertCommand;
using Application.Job.Commands.procEnterpriseRegistration.procEnterpriseRegistrationUpdate.procEnterpriseRegistrationUpdateCommand;
using Application.Job.Quiries.procEnterpriseRegistration;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationByPrimaryKey;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadByPrimaryKeyMSECode;
using Application.Job.Quiries.procEnterpriseRegistration.GetprocEnterpriseRegistrationLoadAll;
using Microsoft.Extensions.Logging;
using Application.Job.Quiries.procEnterpriseRegistration.View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKeys;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procEnterpriseRegistrationController:BaseController
    {
        private readonly ILogger logger;
        public procEnterpriseRegistrationController(ILogger<procEnterpriseRegistrationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocEnterpriseRegistrationLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseRegistrationLoadAllVm>> Get(string TIN)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseRegistrationByPrimaryKey { TIN = TIN });

            return Ok(vm);
        }
        [HttpGet("api/Job/View_Sector_Sub_Sector_Field_Of_Business/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<View_Sector_Sub_Sector_Field_Of_Business>> Getview(string TIN)
        {
            var vm = await Mediator.Send(new View_Sector_Sub_Sector_Field_Of_BusinessByPrimaryKey { TIN = TIN });

            return Ok(vm);
        }
        [HttpGet("MSECode/{MSE_Code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseRegistrationLoadAllVm>> GetByMSECode(string MSE_Code)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseRegistrationLoadByPrimaryKeyMSECode { MSE_Code = MSE_Code });

            return Ok(vm);
        }

        [HttpDelete("{TIN}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string TIN)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procEnterpriseRegistrationDeleteCommand { TIN = TIN });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].TIN;

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
        public async Task<IActionResult> Create([FromBody]procEnterpriseRegistrationInsertCommand command)
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

                var id = vm[0].TIN;

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
        public async Task<IActionResult> Update([FromBody]procEnterpriseRegistrationUpdateCommand command)
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
                var id = vm[0].TIN;
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
