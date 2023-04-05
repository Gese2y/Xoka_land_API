using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Tax.Commands.procTINERCA.procTINERCADelete.procTINERCADeleteCommand;
using Application.Tax.Commands.procTINERCA.procTINERCAInsert.procTINERCAInsertCommand;
using Application.Tax.Commands.procTINERCA.procTINERCAUpdate.procTINERCAUpdateCommand;
using Application.Tax.Quiries.procTINERCA;
using Application.Tax.Quiries.procTINERCA.GetprocTINERCAByPrimaryKey;
using Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadByPrimaryKeyLicenceID;
using Application.Tax.Quiries.procTINERCA.GetprocTINERCALoadAll;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using XOKA.WebUI.Model;
using System.Data;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Tax/[controller]")]
    [ApiController]
    public class procTINERCAController:BaseController
    {
        private readonly ILogger logger;
        private IConfiguration Configuration;
        public procTINERCAController(ILogger<procTINERCAController> logger, IConfiguration _configuration)
        {
            this.logger = logger;
            Configuration = _configuration;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocTINERCALoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SelectByID(string TIN)
        {
            var vm = await Mediator.Send(new GetprocTINERCAByPrimaryKey { TIN = TIN });

                    return Ok(vm);  
        }
        [HttpPost("/api/Tax/procTINERCA/system")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesDefaultResponseType]
        public async Task Create([FromBody] TINERCA commmand)
        {
        
            using (SqlConnection sql = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {

                //MessageBox.Show(sql.State.ToString());
                using (SqlCommand cmd = new SqlCommand("[Tax].[proc_Tin_ERCALoadFormercaSystem]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Tin", commmand.TIN);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    //HttpResponse response;
                    sql.Close();
                    return;
                }
            }
        }

        [HttpGet("LicenceID/{Licence_ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocTINERCALoadAllVm>> GetByLicenceID(Guid Licence_ID)
        {
            var vm = await Mediator.Send(new GetprocTINERCALoadByPrimaryKeyLicenceID { Licence_ID = Licence_ID });

            return Ok(vm);
        }

        [HttpDelete("{TIN}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string TIN)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procTINERCADeleteCommand { TIN = TIN });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].TIN;

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
        public async Task<IActionResult> Create([FromBody]procTINERCAInsertCommand command)
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

                var id = vm[0].TIN;

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
        public async Task<IActionResult> Update([FromBody]procTINERCAUpdateCommand command)
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
                var id = vm[0].TIN;
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
