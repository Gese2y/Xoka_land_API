using Microsoft.AspNetCore.Mvc;
using Persistence;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

namespace XOKA.WebUI.Controllers
{
    [Route("api/view/[controller]")]
    [ApiController]
    public class View_jobassignment_transactionController : BaseController
    {

        private readonly XOKADbContext _context;
        public View_jobassignment_transactionController(XOKADbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vm = _context.View_jobassignment_transaction.ToList();
            return Ok(vm);
        }

    }
}
