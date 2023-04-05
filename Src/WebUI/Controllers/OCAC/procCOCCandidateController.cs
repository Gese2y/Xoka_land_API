using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.OCAC.Commands.procCOCCandidate.procCOCCandidateDelete.procCOCCandidateDeleteCommand;
using Application.OCAC.Commands.procCOCCandidate.procCOCCandidateInsert.procCOCCandidateInsertCommand;
using Application.OCAC.Commands.procCOCCandidate.procCOCCandidateUpdate.procCOCCandidateUpdateCommand;
using Application.OCAC.Quiries.procCOCCandidate;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateByPrimaryKey;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadByPrimaryKeyLicenceID;
using Application.OCAC.Quiries.procCOCCandidate.GetprocCOCCandidateLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/OCAC/[controller]")]
    [ApiController]
    public class procCOCCandidateController:BaseController
    {
        private readonly ILogger logger;
        public procCOCCandidateController(ILogger<procCOCCandidateController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocCOCCandidateLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{COC_Cand_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCOCCandidateLoadAllVm>> Get(Guid COC_Cand_ID)
        {
            var vm = await Mediator.Send(new GetprocCOCCandidateByPrimaryKey { COC_Cand_ID = COC_Cand_ID });

            return Ok(vm);
        }

        [HttpGet("LicenceID/{Licence_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCOCCandidateLoadAllVm>> GetByLicenceID(Guid Licence_ID)
        {
            var vm = await Mediator.Send(new GetprocCOCCandidateLoadByPrimaryKeyLicenceID { Licence_ID = Licence_ID });

            return Ok(vm);
        }

        [HttpDelete("{COC_Cand_ID}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid COC_Cand_ID)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procCOCCandidateDeleteCommand { COC_Cand_ID = COC_Cand_ID });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].COC_Cand_ID;

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
        public async Task<IActionResult> Create([FromBody]procCOCCandidateInsertCommand command)
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

                var id = vm[0].COC_Cand_ID;

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
        public async Task<IActionResult> Update([FromBody]procCOCCandidateUpdateCommand command)
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
                var id = vm[0].COC_Cand_ID;
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
