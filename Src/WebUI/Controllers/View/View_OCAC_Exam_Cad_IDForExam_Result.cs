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
    public class View_OCAC_Exam_Cad_IDForExam_ResultController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_OCAC_Exam_Cad_IDForExam_ResultController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Licence_Id}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(Guid Licence_Id)
        {
            var vm = _context.View_OCAC_Exam_Cad_IDForExam_Result.Where(x => x.Licence_Id == Licence_Id).ToList();
            return Ok(vm);
        }

    }
}
