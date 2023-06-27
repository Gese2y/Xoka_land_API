using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsDelete.procEnterprise_Grade_Points_DetailsDeleteCommand;
using Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsInsert.procEnterprise_Grade_Points_DetailsInsertCommand;
using Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsUpdate.procEnterprise_Grade_Points_DetailsUpdateCommand;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsByPrimaryKey;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsLoadAll;
using Microsoft.Extensions.Logging;
using Application.Job.Quiries.procEnterprise_Grade_Points_Details.GetprocEnterprise_Grade_Points_DetailsByPrimaryKkey;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procEnterprise_Grade_Points_DetailsController : BaseController
    {
        private readonly ILogger logger;
        public procEnterprise_Grade_Points_DetailsController(ILogger<procEnterprise_Grade_Points_DetailsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocEnterprise_Grade_Points_DetailsLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Enterprise_TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterprise_Grade_Points_DetailsLoadAllVm>> Get(string Enterprise_TIN)
        {
            var vm = await Mediator.Send(new GetprocEnterprise_Grade_Points_DetailsByPrimaryKey { Enterprise_TIN = Enterprise_TIN });

            return Ok(vm);
        } [HttpGet("ID/{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterprise_Grade_Points_DetailsLoadAllVm>> Getbyid(string ID)
        {
            var vm = await Mediator.Send(new GetprocEnterprise_Grade_Points_DetailsByPrimaryKkey { ID = ID });

            return Ok(vm);
        }

        [HttpDelete("{ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procEnterprise_Grade_Points_DetailsDeleteCommand { ID = ID });

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
        public async Task<IActionResult> Create([FromBody]procEnterprise_Grade_Points_DetailsInsertCommand command)
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
        public async Task<IActionResult> Update([FromBody]procEnterprise_Grade_Points_DetailsUpdateCommand command)
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
