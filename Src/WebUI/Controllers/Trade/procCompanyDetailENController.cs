﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENDelete.procCompanyDetailENDeleteCommand;
using Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENInsert.procCompanyDetailENInsertCommand;
using Application.Trade.Commands.procCompanyDetailEN.procCompanyDetailENUpdate.procCompanyDetailENUpdateCommand;
using Application.Trade.Quiries.procCompanyDetailEN;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENByPrimaryKey;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber;
using Application.Trade.Quiries.procCompanyDetailEN.GetprocCompanyDetailENLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Trade/[controller]")]
    [ApiController]
    public class procCompanyDetailENController:BaseController
    {
        private readonly ILogger logger;
        public procCompanyDetailENController(ILogger<procCompanyDetailENController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocCompanyDetailENLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCompanyDetailENLoadAllVm>> Get(Guid ID)
        {
            var vm = await Mediator.Send(new GetprocCompanyDetailENByPrimaryKey { ID = ID });

            return Ok(vm);
        }

        [HttpGet("COMREGNumber/{COM_REG_Number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCompanyDetailENLoadAllVm>> GetByCOMREGNumber(string COM_REG_Number)
        {
            var vm = await Mediator.Send(new GetprocCompanyDetailENLoadByPrimaryKeyCOMREGNumber { COM_REG_Number = COM_REG_Number });

            return Ok(vm);
        }

        [HttpDelete("{ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procCompanyDetailENDeleteCommand { ID = ID });

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
        public async Task<IActionResult> Create([FromBody]procCompanyDetailENInsertCommand command)
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
        public async Task<IActionResult> Update([FromBody]procCompanyDetailENUpdateCommand command)
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
