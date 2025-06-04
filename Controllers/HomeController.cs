using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portal_cliente.Models;

namespace portal_cliente.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(); // Retorna a view Index.cshtml
    }

    // Outras actions do HomeController...
}