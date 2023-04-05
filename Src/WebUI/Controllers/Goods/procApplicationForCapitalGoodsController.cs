using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsDelete.procApplicationForCapitalGoodsDeleteCommand;
using Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsInsert.procApplicationForCapitalGoodsInsertCommand;
using Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsUpdate.procApplicationForCapitalGoodsUpdateCommand;
using Application.Goods.Quiries.procApplicationForCapitalGoods;
using Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsByPrimaryKey;
using Application.Goods.Quiries.procApplicationForCapitalGoods.procApplicationForCapitalGoodsLoadByPrimaryKeyLicenceId;
using Application.Goods.Quiries.procApplicationForCapitalGoods.GetprocApplicationForCapitalGoodsLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Goods/[controller]")]
    [ApiController]
    public class procApplicationForCapitalGoodsController:BaseController
    {
        private readonly ILogger logger;
        public procApplicationForCapitalGoodsController(ILogger<procApplicationForCapitalGoodsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocApplicationForCapitalGoodsLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocApplicationForCapitalGoodsLoadAllVm>> Get(Guid ID)
        {
            var vm = await Mediator.Send(new GetprocApplicationForCapitalGoodsByPrimaryKey { ID = ID });

            return Ok(vm);
        }

        [HttpGet("LicenceId/{Licence_Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocApplicationForCapitalGoodsLoadAllVm>> GetByLicenceId(Guid Licence_Id)
        {
            var vm = await Mediator.Send(new procApplicationForCapitalGoodsLoadByPrimaryKeyLicenceId { Licence_Id = Licence_Id });

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

                var vm = await Mediator.Send(new procApplicationForCapitalGoodsDeleteCommand { ID = ID });

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
        public async Task<IActionResult> Create([FromBody]procApplicationForCapitalGoodsInsertCommand command)
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
        public async Task<IActionResult> Update([FromBody]procApplicationForCapitalGoodsUpdateCommand command)
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
