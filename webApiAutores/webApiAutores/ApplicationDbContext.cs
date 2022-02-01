using Microsoft.EntityFrameworkCore;
using webApiAutores.Entidades;

namespace webApiAutores
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
    }
}
