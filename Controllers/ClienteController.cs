using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        // Criando a rota para listar os usuários cadastrados
        public IActionResult Lista()
        {
            return View();
        }

        // Criando a rota para cadastrar os usuários
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
