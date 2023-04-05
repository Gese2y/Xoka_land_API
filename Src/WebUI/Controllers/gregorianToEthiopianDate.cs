using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;


using Microsoft.Extensions.Logging;
using EthiopianCalendar;
using System.Text.Json;

namespace XOKA.WebUI.Controllers
{
    public class Nowdate
    {
        public string nowTime { get; set; }
    } 

    [Route("api/[controller]")]
    [ApiController]
    public class gregorianToEthiopianDateController:BaseController
    {
      
        [HttpGet("{year}/{month}/{day}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Get(int year , int month, int day)
        {
            EthiopianDate ethiopianDate = new EthiopianDate(new DateTime(year, month, day));

            var vm = ethiopianDate.ToString("dd/M/yyyy");
            var dateObject = new Nowdate
            {
                nowTime = vm
            };
            string jsonString = JsonSerializer.Serialize(dateObject);

            return Ok(jsonString);
        }


    
    }
}
