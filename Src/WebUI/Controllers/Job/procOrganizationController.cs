using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Job.Commands.procOrganization.procOrganizationDelete.procOrganizationDeleteCommand;
using Application.Job.Commands.procOrganization.procOrganizationInsert.procOrganizationInsertCommand;
using Application.Job.Commands.procOrganization.procOrganizationUpdate.procOrganizationUpdateCommand;
using Application.Job.Quiries.procOrganization;
using Application.Job.Quiries.procOrganization.GetprocOrganizationByPrimaryKeyParent;
using Application.Job.Quiries.procOrganization.GetprocOrganizationByPrimaryKey;
using Application.Job.Quiries.procOrganization.GetprocOrganizationLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Job/[controller]")]
    [ApiController]
    public class procOrganizationController : BaseController
    {
        private readonly ILogger logger;
        public procOrganizationController(ILogger<procOrganizationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocOrganizationLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{organization_code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocOrganizationLoadAllQuery>> Get(string organization_code)
        {
            var vm = await Mediator.Send(new GetprocOrganizationByPrimaryKey { organization_code = organization_code });

            return Ok(vm);
        }

        [HttpGet("Organization/{organizations_organization_code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocOrganizationLoadAllQuery>> GetParent(string organizations_organization_code)
        {
            var vm = await Mediator.Send(new GetprocOrganizationByPrimaryKeyParent { organizations_organization_code = organizations_organization_code });

            return Ok(vm);
        }

        [HttpDelete("{organization_code}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string organization_code)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procOrganizationDeleteCommand { organization_code = organization_code });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].organization_code;

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
        public async Task<IActionResult> Create([FromBody]procOrganizationInsertCommand command)
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

                var id = vm[0].organization_code;

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
        public async Task<IActionResult> Update([FromBody]procOrganizationUpdateCommand command)
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
                var id = vm[0].organization_code;
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
