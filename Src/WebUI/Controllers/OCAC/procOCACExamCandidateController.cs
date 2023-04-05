using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateDelete.procOCACExamCandidateDeleteCommand;
using Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateInsert.procOCACExamCandidateInsertCommand;
using Application.OCAC.Commands.procOCACExamCandidate.procOCACExamCandidateUpdate.procOCACExamCandidateUpdateCommand;
using Application.OCAC.Quiries.procOCACExamCandidate;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateByPrimaryKey;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID;
using Application.OCAC.Quiries.procOCACExamCandidate.GetprocOCACExamCandidateLoadAll;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/OCAC/[controller]")]
    [ApiController]
    public class procOCACExamCandidateController:BaseController
    {
        private readonly ILogger logger;
        public procOCACExamCandidateController(ILogger<procOCACExamCandidateController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocOCACExamCandidateLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{OCAC_Candiate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocOCACExamCandidateLoadAllVm>> Get(Guid OCAC_Candiate)
        {
            var vm = await Mediator.Send(new GetprocOCACExamCandidateByPrimaryKey { OCAC_Candiate = OCAC_Candiate });

            return Ok(vm);
        }

        [HttpGet("OCACExamPlanID/{OCAC_Exam_Plan_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocOCACExamCandidateLoadAllVm>> GetByOCACExamPlanID(Guid OCAC_Exam_Plan_ID)
        {
            var vm = await Mediator.Send(new GetprocOCACExamCandidateLoadByPrimaryKeyOCACExamPlanID { OCAC_Exam_Plan_ID = OCAC_Exam_Plan_ID });

            return Ok(vm);
        }

        [HttpDelete("{OCAC_Candiate}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid OCAC_Candiate)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procOCACExamCandidateDeleteCommand { OCAC_Candiate = OCAC_Candiate });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].OCAC_Candiate;

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
        public async Task<IActionResult> Create([FromBody]procOCACExamCandidateInsertCommand command)
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

                var id = vm[0].OCAC_Candiate;

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
        public async Task<IActionResult> Update([FromBody]procOCACExamCandidateUpdateCommand command)
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
                var id = vm[0].OCAC_Candiate;
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
