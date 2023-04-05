using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeDelete.procUnEmployeeDeleteCommand;
using Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeInsert.procUnEmployeeInsertCommand;
using Application.UnEmployment.Quiries.procUnEmployee;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeByPrimaryKey;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadByPrimaryKeyVitalID;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadAll;
using Microsoft.Extensions.Logging;
using Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeUpdate.procUnEmployeeUpdateCommand;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadAll;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID;

namespace XOKA.WebUI.Controllers
{
    [Route("api/UnEmployment/[controller]")]
    [ApiController]
    public class procUnEmployeeController : BaseController
    {
        private readonly ILogger logger;
        public procUnEmployeeController(ILogger<procUnEmployeeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var vm = await Mediator.Send(new GetprocUnEmployeeLoadAllQuery() { });
            return Ok(vm);
        }
         [HttpGet("api/UnEmployment/")]
        public async Task<IActionResult> GetAllinfo()
        {

            var vm = await Mediator.Send(new GetprocUnEmployeeinfoLoadAllQuery() { });
            return Ok(vm);
        }

        [HttpGet("{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocUnEmployeeLoadAllVm>> Get(string TIN)
        {
            var vm = await Mediator.Send(new GetprocUnEmployeeByPrimaryKey { TIN = TIN });

            return Ok(vm);
        }

        [HttpGet("VitalID/{Vital_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocUnEmployeeLoadAllVm>> GetByVitalID(string Vital_ID)
        {
            var vm = await Mediator.Send(new GetprocUnEmployeeLoadByPrimaryKeyVitalID { Vital_ID = Vital_ID });

            return Ok(vm);
        } 
        [HttpGet("VitalID/VitalID/info/{Vital_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocUnEmployeeinfoLoadAllVm>> GetByVitalIDinfo(string Vital_ID)
        {
            var vm = await Mediator.Send(new GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID { Vital_ID = Vital_ID });

            return Ok(vm);
        }

        [HttpDelete("{Vital_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string Vital_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procUnEmployeeDeleteCommand { Vital_ID = Vital_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Vital_ID;

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
        public async Task<IActionResult> Create([FromBody]procUnEmployeeInsertCommand command)
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

                var id = vm[0].Vital_ID;

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
        public async Task<IActionResult> Update([FromBody]procUnEmployeeUpdateCommand command)
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
                var id = vm[0].Vital_ID;
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
