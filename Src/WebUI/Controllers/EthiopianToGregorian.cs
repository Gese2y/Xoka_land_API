using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;
using System.Text.Json;

using Microsoft.Extensions.Logging;
using EthiopianCalendar;

namespace XOKA.WebUI.Controllers
{
     public class NowTime
{
    public DateTime nowTime { get; set; }
}
    [Route("api/[controller]")]
    [ApiController]
    public class EthiopianToGregorianController : BaseController
    {
      
        [HttpGet("{year}/{month}/{day}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Get(int year, int month, int day)
        {

            EthiopianDate ethiopianDate = new EthiopianDate(year, month, day);
            var vm = ethiopianDate.ToGregorianDate();
           
            var dateObject = new NowTime
            {
               nowTime=  vm
            };
            string jsonString = JsonSerializer.Serialize(dateObject);

            return Ok( jsonString);
        }

        


    }
   
}
