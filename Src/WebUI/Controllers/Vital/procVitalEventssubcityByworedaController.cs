using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;


using Application.Vital.Quiries.VitalEventsGetSubcityByWoreda;
using Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.VitalEventsGetSubcityByWoredaLoadAll;
using Application.Vital.Quiries.VitalEventsGetSubcityByWoreda.GetVitalEventsGetSubcityByWoredaByPrimaryKey;

using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/Vital/[controller]")]
    [ApiController]
    public class procVitalEventssubcityByworedaController : BaseController
    {
        private readonly ILogger logger;
        public procVitalEventssubcityByworedaController(ILogger<procVitalEventssubcityByworedaController> logger)
        {
            this.logger = logger;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var vm = await Mediator.Send(new GetVitalEventsGetSubcityByWoredaOrgLoadAllQuery() { });
        //    return Ok(vm);
        //}

        [HttpGet("{ID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetVitalEventsGetSubcityByWoredaOrgLoadAllVm>> Get(string ID)
        {
            var vm = await Mediator.Send(new GetVitalEventsGetSubcityByWoredaByPrimaryKey { ID = ID });

            return Ok(vm);
        }

    }
}
