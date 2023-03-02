using LibrosEjemplo.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrosEjemplo
{
    public class ApplicationDbContextcs: DbContext
    {
        public ApplicationDbContextcs(DbContextOptions options): base(options) 
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
