using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationDelete.procCommercialRegistrationDeleteCommand;
using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationUpdate.procCommercialRegistrationUpdateCommand;
using Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationInsert.procCommercialRegistrationInsertCommand;
using Application.Trade.Quiries.procCommercialRegistration;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationByPrimaryKey;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadByPrimaryKeyTIN;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadAll;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using XOKA.WebUI.Model;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Trade/[controller]")]
    [ApiController]
    public class Trade_procCommercialRegistrationController : BaseController
    {
        private readonly ILogger logger;
        private IConfiguration Configuration;

        public Trade_procCommercialRegistrationController(ILogger<Trade_procCommercialRegistrationController> logger, IConfiguration _configuration)
        {
            this.logger = logger;
            Configuration = _configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationLoadAllQuery() { });

            return Ok(vm);
        }

        [HttpGet("{COM_REG_Number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCommercialRegistrationLoadAllVm>> Get(string COM_REG_Number)
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationByPrimaryKey { COM_REG_Number = COM_REG_Number });

            return Ok(vm);
        }
        [HttpPost("/api/Tax/proctrade/system")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesDefaultResponseType]
        public async Task Create([FromBody] Trade commmand)
        {

            using (SqlConnection sql = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
            {

                //MessageBox.Show(sql.State.ToString());
                using (SqlCommand cmd = new SqlCommand("[Trade].[proc_Commercial_RegistrationInsertSystem]", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Tin", commmand.Tin);
                    await sql.OpenAsync();
                    cmd.CommandTimeout = 300;
                    await cmd.ExecuteNonQueryAsync();
                    //HttpResponse response;
                    sql.Close();
                    return;
                }
            }
        }
   //     [HttpPost("Tin/Tin/Tin/Tin/Tin")]
   //     public async Task Creatte([FromBody] Trade commmand)
   //     {
            


   //             HttpClient clients = new HttpClient();

   //             HttpResponseMessage respo = clients.GetAsync
   //             (this.Configuration.GetValue<string>("Credential:tradURL") + commmand.Tin).Result;
               
   //                 dynamic json = JObject.Parse(respo.Content.ReadAsStringAsync().Result);
   //                 using (SqlConnection sql = new SqlConnection(this.Configuration.GetConnectionString("XOKADatabase")))
   //                 {

   //                     //MessageBox.Show(sql.State.ToString());
   //                     using (SqlCommand cmd = new SqlCommand("[Trade].[proc_ComercialRegistrationfromTrade]", sql))
   //                     {
   //                         cmd.CommandType = System.Data.CommandType.StoredProcedure;
                           
   //cmd.Parameters.AddWithValue("@Tin", json.Tin.ToString());
   //cmd.Parameters.AddWithValue("@LegalCondtion", json.LegalCondtion.ToString());
   //cmd.Parameters.AddWithValue("@RegNo", json.RegNo.ToString());
   //cmd.Parameters.AddWithValue("@RegDate", json.RegDate.ToString());
   //cmd.Parameters.AddWithValue("@BusinessName", json.BusinessName.ToString());
   //cmd.Parameters.AddWithValue("@BusinessNameAmh", json.BusinessNameAmh.ToString());
   //cmd.Parameters.AddWithValue("@PaidUpCapital", json.PaidUpCapital.ToString());
   //cmd.Parameters.AddWithValue("@Position", json.AssociateShortInfos[0].Position.ToString());
   //cmd.Parameters.AddWithValue("@ManagerName", json.AssociateShortInfos[0].ManagerName.ToString());
   //cmd.Parameters.AddWithValue("@ManagerNameEng", json.AssociateShortInfos[0].ManagerNameEng.ToString());
   //cmd.Parameters.AddWithValue("@Photo", json.AssociateShortInfos[0].Photo.ToString());
   //cmd.Parameters.AddWithValue("@MobilePhone", json.AssociateShortInfos[0].MobilePhone.ToString());
   //cmd.Parameters.AddWithValue("@RegularPhone", json.AssociateShortInfos[0].RegularPhone.ToString());
   //cmd.Parameters.AddWithValue("@OwnerTIN", json.Businesses[0].OwnerTIN.ToString());
   //cmd.Parameters.AddWithValue("@DateRegistered", json.Businesses[0].DateRegistered.ToString());
   //cmd.Parameters.AddWithValue("@TradeNameAmh", json.Businesses[0].TradeNameAmh.ToString());
   //cmd.Parameters.AddWithValue("@TradesName", json.Businesses[0].TradesName.ToString());
   //cmd.Parameters.AddWithValue("@LicenceNumber", json.Businesses[0].LicenceNumber.ToString());
   //cmd.Parameters.AddWithValue("@RenewalDate", json.Businesses[0].RenewalDate.ToString());
   //cmd.Parameters.AddWithValue("@RenewedFrom", json.Businesses[0].RenewedFrom.ToString());
   //cmd.Parameters.AddWithValue("@RenewedTo", json.Businesses[0].RenewedTo.ToString());
   //cmd.Parameters.AddWithValue("@BusinessLicensingGroupMain", json.Businesses[0].BusinessLicensingGroupMain.ToString());
   //cmd.Parameters.AddWithValue("@Code", json.Businesses[0].SubGroups[0].Code.ToString());
   //cmd.Parameters.AddWithValue("@Description", json.Businesses[0].SubGroups[0].Description.ToString());
   //                 await sql.OpenAsync();
   //                 cmd.CommandTimeout = 300;
   //                         await cmd.ExecuteNonQueryAsync();
   //                         //HttpResponse response;
   //                         sql.Close();
   //                     return;
   //                     }
   //                 }
                 


   //     }
        [HttpGet("TIN/{TIN}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetprocCommercialRegistrationLoadAllVm>> GetByTIN(long TIN)
        {
            var vm = await Mediator.Send(new GetprocCommercialRegistrationLoadByPrimaryKeyTIN { TIN = TIN });

            return Ok(vm);
        }

        [HttpDelete("{COM_REG_Number}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string COM_REG_Number)
        {
            
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var vm = await Mediator.Send(new procCommercialRegistrationDeleteCommand { COM_REG_Number = COM_REG_Number });

                if (vm == null || !vm.Any())
                {
                    this.logger.LogInformation("Delete: something went wrong");
                    return BadRequest("something went wrong");
                }

                var id = vm[0].COM_REG_Number;

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
        public async Task<IActionResult> Create([FromBody]procCommercialRegistrationInsertCommand command)
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

                var id = vm[0].COM_REG_Number;

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
        public async Task<IActionResult> Update([FromBody]procCommercialRegistrationUpdateCommand command)
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
                var id = vm[0].COM_REG_Number;
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
