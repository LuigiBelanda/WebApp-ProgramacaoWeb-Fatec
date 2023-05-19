using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

// Controller que irá cuidar das rotas relacionadas aos Produtos
namespace WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<ProdutosModel> db = new List<ProdutosModel>();

        // Criando a rota para listar os produtos cadastrados
        public IActionResult Lista(String filtro, string busca)
        {
            if ( string.IsNullOrEmpty(busca) )
            {
                return View(db);
            } 
            else
            {
                switch ( filtro ) 
                {
                    case "id":
                        return View(db.Where(a => a.Id.ToString() == busca).ToList());
                        break;

                    case "nome":
                        return View(db.Where(a => a.Nome.Contains(busca)).ToList());
                        break;

                    case "qtd":
                        return View(db.Where(a => a.QtdEstoque.ToString() == busca).ToList());
                        break;

                    default:
                        return View(db.Where(a => a.Id.ToString() == busca || a.Nome.Contains(busca) || a.QtdEstoque.ToString() == busca).ToList());
                        break;
                }
            }
            
        }

        // Criando a rota para cadastrar os produtos
        public IActionResult Cadastrar()
        {
            ProdutosModel model = new ProdutosModel();

            return View( model );
        }

        [HttpPost]
        public IActionResult SalvarDados(ProdutosModel produto)
        {
            if (produto.Id == 0)
            {
                Random rand = new Random();
                produto.Id = rand.Next(1, 9999);

                db.Add(produto);
            }
            else
            {
                int indice = db.FindIndex(a => a.Id == produto.Id);
                db[indice] = produto;
            }

            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            ProdutosModel item = db.Find(a => a.Id == id);

            if (item != null)
            {
                db.Remove(item);
            }

            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int id)
        {
            ProdutosModel item = db.Find(produto => produto.Id == id);

            if (item != null)
            {
                return View(item);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
    }
}
