using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinhaArte.Models;

namespace MinhaArte.Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<QuadroModel> Quadro { get; set; }
        public DbSet<CategoriaModel> Categoria { get; set; }    
    }
}