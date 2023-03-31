using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

// Controller que irá cuidar das rotas relacionadas aos Produtos
namespace WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        // Criando a rota para listar os produtos cadastrados
        public IActionResult Lista()
        {
            return View();
        }

        // Criando a rota para cadastrar os produtos
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
