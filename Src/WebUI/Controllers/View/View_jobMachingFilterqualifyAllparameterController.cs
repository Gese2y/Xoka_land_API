using Microsoft.AspNetCore.Mvc;
using Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_jobMachingFilterqualifyAllparameterController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_jobMachingFilterqualifyAllparameterController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Job_Opportunity_ID}/{Woreda}/{QualifyBYAllParameter}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Job_Opportunity_ID , Guid Woreda , string QualifyBYAllParameter)
        {
            var vm = _context.View_jobMachingFilterqualifyAllparameter.Where(x => x.Job_Opportunity_ID == Job_Opportunity_ID && x.Woreda == Woreda && x.QualifyBYAllParameter==QualifyBYAllParameter).ToList();
            return Ok(vm);
        }

    }
}
