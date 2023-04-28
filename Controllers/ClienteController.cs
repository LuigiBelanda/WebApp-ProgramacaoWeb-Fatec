using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {
        public static List<ClientesModel> db = new List<ClientesModel>();

        // Criando a rota para listar os usuários cadastrados
        public IActionResult Lista()
        {
            return View( db ); 
        }

        // Criando a rota para cadastrar os usuários
        public IActionResult Cadastrar()
        {
            // Instanciando o nosso model de Clientes
            ClientesModel model = new ClientesModel();

            // Enviando junto com a tela o nosso model que foi instanciado
            return View( model );
        }

        [HttpPost]
        public IActionResult SalvarDados(ClientesModel cliente)
        {
            if (cliente.Id == 0)
            {
                Random rand = new Random();
                cliente.Id = rand.Next(1, 9999);

                db.Add(cliente);
            }

            return RedirectToAction("Lista");
        }
    }
}
