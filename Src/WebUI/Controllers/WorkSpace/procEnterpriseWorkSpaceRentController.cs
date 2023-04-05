using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentDelete.procEnterpriseWorkSpaceRentDeleteCommand;
using Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentInsert.procEnterpriseWorkSpaceRentInsertCommand;
using Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentUpdate.procEnterpriseWorkSpaceRentUpdateCommand;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByPrimaryKey;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByTin;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/WorkSpace/[controller]")]
    [ApiController]
    public class procEnterpriseWorkSpaceRentController:BaseController
    {
        private readonly ILogger logger;
        public procEnterpriseWorkSpaceRentController(ILogger<procEnterpriseWorkSpaceRentController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocEnterpriseWorkSpaceRentLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Work_Space_ID}/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseWorkSpaceRentLoadAllVm>> Get(Guid Work_Space_ID, string TIN)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseWorkSpaceRentByPrimaryKey { Work_Space_ID = Work_Space_ID, TIN = TIN });

            return Ok(vm);
        }
        [HttpGet("{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocEnterpriseWorkSpaceRentLoadAllVm>> Get( string TIN)
        {
            var vm = await Mediator.Send(new GetprocEnterpriseWorkSpaceRentByTin {TIN = TIN });

            return Ok(vm);
        }

        [HttpDelete("{Work_Space_ID}/{TIN}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Work_Space_ID, string TIN)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procEnterpriseWorkSpaceRentDeleteCommand { Work_Space_ID = Work_Space_ID, TIN = TIN });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id_1 = vm[0].Work_Space_ID;
                var id_2 = vm[0].TIN;

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
        public async Task<IActionResult> Create([FromBody]procEnterpriseWorkSpaceRentInsertCommand command)
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

                var id_1 = vm[0].Work_Space_ID;
                var id_2 = vm[0].TIN;

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
        public async Task<IActionResult> Update([FromBody]procEnterpriseWorkSpaceRentUpdateCommand command)
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

                var id_1 = vm[0].Work_Space_ID;
                var id_2 = vm[0].TIN;

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
