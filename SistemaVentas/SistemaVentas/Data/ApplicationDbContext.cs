using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVentas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TUsers> TUsers { get; set; }
    }
}
