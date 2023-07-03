using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionDelete.procSub_City_Job_Assignment_TransactionDeleteCommand;
using Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionInsert.procSub_City_Job_Assignment_TransactionInsertCommand;
using Application.Job.Commands.procSub_City_Job_Assignment_Transaction.procSub_City_Job_Assignment_TransactionUpdate.procSub_City_Job_Assignment_TransactionUpdateCommand;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionByPrimaryKey;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionLoadAll;
using Microsoft.Extensions.Logging;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.Getproc_Sub_City_Job_Assignment_TransactionLoadByPrimaryKeyforsubcity;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procSub_City_Job_Assignment_TransactionController:BaseController
    {
        private readonly ILogger logger;
        public procSub_City_Job_Assignment_TransactionController(ILogger<procSub_City_Job_Assignment_TransactionController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocSub_City_Job_Assignment_TransactionLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Job_Opportunity_ID}/{Sub_City}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocSub_City_Job_Assignment_TransactionLoadAllVm>> Get(Guid Job_Opportunity_ID, Guid Sub_City)
        {
            var vm = await Mediator.Send(new GetprocSub_City_Job_Assignment_TransactionByPrimaryKey { Job_Opportunity_ID = Job_Opportunity_ID, Sub_City= Sub_City }); ;

            return Ok(vm);
        }
        [HttpGet("forsubcity/{Job_Opportunity_ID}/{Sub_City}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocSub_City_Job_Assignment_TransactionLoadAllVm>> Getforsubcity(Guid Job_Opportunity_ID, Guid Sub_City)
        {
            var vm = await Mediator.Send(new Getproc_Sub_City_Job_Assignment_TransactionLoadByPrimaryKeyforsubcity { Job_Opportunity_ID = Job_Opportunity_ID, Sub_City = Sub_City }); ;

            return Ok(vm);
        }



        [HttpDelete("{Transaction_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Transaction_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procSub_City_Job_Assignment_TransactionDeleteCommand { Transaction_ID = Transaction_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Transaction_ID;

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
        public async Task<IActionResult> Create([FromBody]procSub_City_Job_Assignment_TransactionInsertCommand command)
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

                var id = vm[0].Transaction_ID;

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
        public async Task<IActionResult> Update([FromBody]procSub_City_Job_Assignment_TransactionUpdateCommand command)
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
                var id = vm[0].Transaction_ID;
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
