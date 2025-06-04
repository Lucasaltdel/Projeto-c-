using Microsoft.AspNetCore.Mvc;

namespace portal_cliente.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Retorna a view dashboard.cshtml
        }
    }
}