using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinDelete.procLicenceServiceForSingleWinDeleteCommand;
using Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinInsert.procLicenceServiceForSingleWinInsertCommand;
using Application.dbo.Commands.procLicenceServiceForSingleWin.procLicenceServiceForSingleWinUpdate.procLicenceServiceForSingleWinUpdateCommand;
using Application.dbo.Quiries.procLicenceServiceForSingleWin;
using Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinByPrimaryKey;
using Application.dbo.Quiries.procLicenceServiceForSingleWin.GetprocLicenceServiceForSingleWinLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/dbo/[controller]")]
    [ApiController]
    public class procLicenceServiceForSingleWinController:BaseController
    {
        private readonly ILogger logger;
        public procLicenceServiceForSingleWinController(ILogger<procLicenceServiceForSingleWinController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocLicenceServiceForSingleWinLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{Licence_Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocLicenceServiceForSingleWinLoadAllVm>> Get(Guid Licence_Id)
        {
            var vm = await Mediator.Send(new GetprocLicenceServiceForSingleWinByPrimaryKey { Licence_Id = Licence_Id });

            return Ok(vm);
        }

        [HttpDelete("{Licence_Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid Licence_Id)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procLicenceServiceForSingleWinDeleteCommand { Licence_Id = Licence_Id });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].Licence_Id;

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
        public async Task<IActionResult> Create([FromBody]procLicenceServiceForSingleWinInsertCommand command)
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

                var id = vm[0].Licence_Id;

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
        public async Task<IActionResult> Update([FromBody]procLicenceServiceForSingleWinUpdateCommand command)
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
                var id = vm[0].Licence_Id;
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
