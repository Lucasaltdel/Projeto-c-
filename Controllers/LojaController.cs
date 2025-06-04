using Microsoft.AspNetCore.Mvc;
using portal_cliente.csproj.Data;
using portal_cliente.csproj.Models;

namespace portal_cliente.csproj.Controllers
{
    public class LojaController : Controller
    {
        private readonly AppDbContext _context;

        public LojaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Loja loja)
        {
            if (ModelState.IsValid)
            {
                _context.Lojas.Add(loja);
                _context.SaveChanges();
                return RedirectToAction("Sucesso");
            }

            return View(loja);
        }

        public IActionResult Sucesso()
        {
            return View(); 
        }
    }
}
