using Microsoft.EntityFrameworkCore;

namespace WebApp
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
    }
}
