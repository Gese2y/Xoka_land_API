using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeDelete.procStakeholder_EmployeeDeleteCommand;
using Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeInsert.procStakeholder_EmployeeInsertCommand;
using Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeUpdate.procStakeholder_EmployeeUpdateCommand;
using Application.Job.Quiries.procStakeholder_Employee;
using Application.Job.Quiries.procStakeholder_Employee.GetprocStakeholder_EmployeeByPrimaryKey;
using Application.Job.Quiries.procStakeholder_Employee.GetprocStakeholder_EmployeeLoadAll;
using Microsoft.Extensions.Logging;
namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procStakeholder_EmployeeController:BaseController
    {
        private readonly ILogger logger;
        public procStakeholder_EmployeeController(ILogger<procStakeholder_EmployeeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocStakeholder_EmployeeLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Stakeholder_Employee_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocStakeholder_EmployeeLoadAllVm>> Get(Guid Stakeholder_Employee_ID)
        {
            var vm = await Mediator.Send(new GetprocStakeholder_EmployeeByPrimaryKey { Stakeholder_Employee_ID = Stakeholder_Employee_ID });

            return Ok(vm);
        }

      

        [HttpDelete("{Stakeholder_Employee_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Stakeholder_Employee_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procStakeholder_EmployeeDeleteCommand { Stakeholder_Employee_ID = Stakeholder_Employee_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Stakeholder_Employee_ID;

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
        public async Task<IActionResult> Create([FromBody]procStakeholder_EmployeeInsertCommand command)
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

                var id = vm[0].Stakeholder_Employee_ID;

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
        public async Task<IActionResult> Update([FromBody]procStakeholder_EmployeeUpdateCommand command)
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
                var id = vm[0].Stakeholder_Employee_ID;
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
