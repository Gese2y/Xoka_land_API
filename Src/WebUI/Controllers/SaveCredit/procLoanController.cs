using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.SaveCredit.Commands.procLoan.procLoanDelete.procLoanDeleteCommand;
using Application.SaveCredit.Commands.procLoan.procLoanInsert.procLoanInsertCommand;
using Application.SaveCredit.Commands.procLoan.procLoanUpdate.procLoanUpdateCommand;
using Application.SaveCredit.Quiries.procLoan;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanByPrimaryKey;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/SaveCredit/[controller]")]
    [ApiController]
    public class procLoanController : BaseController
    {
        private readonly ILogger logger;
        public procLoanController(ILogger<procLoanController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocLoanLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Loan_Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocLoanLoadAllVm>> Get(Guid Loan_Id)
        {
            var vm = await Mediator.Send(new GetprocLoanByPrimaryKey { Loan_Id = Loan_Id });

            return Ok(vm);
        }

        [HttpGet("ApplicationCodeCreadit/{ApplicationCodeCreadit}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocLoanLoadAllVm>> GetByApplicationCodeCreadit(Guid ApplicationCodeCreadit)
        {
            var vm = await Mediator.Send(new GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit { ApplicationCodeCreadit = ApplicationCodeCreadit });

            return Ok(vm);
        }

        [HttpDelete("{Loan_Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Loan_Id)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procLoanDeleteCommand { Loan_Id = Loan_Id });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Loan_Id;

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
        public async Task<IActionResult> Create([FromBody] procLoanInsertCommand command)
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

                var id = vm[0].Loan_Id;

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
        public async Task<IActionResult> Update([FromBody] procLoanUpdateCommand command)
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
                var id = vm[0].Loan_Id;
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
