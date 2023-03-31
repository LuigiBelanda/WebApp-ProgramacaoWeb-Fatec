using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
