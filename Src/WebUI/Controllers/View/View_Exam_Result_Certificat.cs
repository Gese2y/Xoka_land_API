using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_Exam_Result_CertificatController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_Exam_Result_CertificatController(XOKADbContext context)
        {
            this._context = context;
        }


        [HttpGet("{Licence_Id}")]
        [ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(System.Guid Licence_Id)
        {
            var vm = _context.View_Exam_Result_Certificat.Where(x => x.Licence_Id == Licence_Id).ToList();
            return Ok(vm);
        }

    }
}
