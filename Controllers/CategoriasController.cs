﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Lista(String Busca)
        {
            if ( string.IsNullOrEmpty(Busca) )
            {
                return View(db.Categorias.ToList());
            }
            else
            {
                List<Categorias> dados = new List<Categorias>();
                dados = db.Categorias.Where(a => a.Nome.Contains(Busca)).ToList();

                return View(dados); 
            }
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
