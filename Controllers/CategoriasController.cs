using Microsoft.AspNetCore.Mvc;
using WebApp.Tabelas;

namespace WebApp.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto db;

        public CategoriasController( Contexto contexto )
        {
            db = contexto;
        }

        public IActionResult Lista()
        {
            return View( db.Categorias.ToList() );
        }

        public IActionResult Cadastro() 
        { 
            return View( new Categorias() ); 
        }

        [HttpPost]
        public IActionResult SalvarDados(Categorias dados) 
        {
            db.Categorias.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
