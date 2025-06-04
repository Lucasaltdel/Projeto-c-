using Microsoft.AspNetCore.Mvc;

namespace portal_cliente.Controllers
{
    public class PlanosController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Retorna a view planos.cshtml
        }
    }
}