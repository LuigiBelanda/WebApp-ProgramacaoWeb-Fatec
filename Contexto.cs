using Microsoft.EntityFrameworkCore;
using WebApp.Tabelas;

namespace WebApp
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }

        public DbSet<Categorias> Categorias { get; set; }
    }
}
