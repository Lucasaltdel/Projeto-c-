using Microsoft.AspNetCore.Mvc;
using portal_cliente.csproj.Data;
using portal_cliente.csproj.Models;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace portal_cliente.csproj.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Cliente/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // POST: /Cliente/Cadastro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastro(Loja loja)
        {
            if (ModelState.IsValid)
            {
                _context.Lojas.Add(loja);
                _context.SaveChanges();

                // ======= Envio de e-mail após cadastro =======
                try
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Eficaz Marketing e Tecnologia", "eficazmarketingetecnologia@gmail.com"));
                    message.To.Add(new MailboxAddress(loja.NomeFantasia, loja.Email)); // supondo que Loja tem Nome e Email
                    message.Subject = "🎉 Seja bem-vindo à Eficaz Marketing — Vamos acelerar seus resultados!";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"Olá {loja.NomeFantasia}, " +
                        $"Parabéns por dar o primeiro passo rumo a uma presença digital mais eficaz!" +
                        $"Agora que você concluiu seu cadastro e escolheu seu plano conosco, é hora de colocarmos a mão na massa." +
                        $"Nosso time já está pronto para começar a traçar sua estratégia de marketing sob medida." +
                        $"" +
                        $"Obrigado por confiar na Eficaz Marketing." +
                        $"Vamos transformar sua marca em uma máquina de conversão!" +
                        $"" +
                        $"Um abraço," +
                        $"Equipe Eficaz Marketing" +
                        $"contato@eficazmarketing.com" +
                        $"eficazmarketing.com"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                        client.Authenticate("eficazmarketingetecnologia@gmail.com", "gufq gipm ifdx dwyq");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    // (Opcional) log de erro, mas não impede o fluxo do sistema
                    Console.WriteLine("Erro ao enviar email: " + ex.Message);
                }
                // =============================================

                return RedirectToAction("Finalizacao");
            }

            return View(loja);
        }

        // GET: /Cliente/Finalizacao
        public IActionResult Finalizacao()
        {
            return View();
        }

        // GET: /Cliente/Dados
        public IActionResult Dados()
        {
            return View();
        }
    }
}
