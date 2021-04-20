using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers.Admin
{
    public class PainelDoUsuarioController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}