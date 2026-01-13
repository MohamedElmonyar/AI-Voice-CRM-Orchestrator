using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OSV.Controllers
{

    [Authorize]
    public class CustomersController : Controller 
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
