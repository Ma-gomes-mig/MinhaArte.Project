using MinhaArte.Models;
using MinhaArte.Project.Data;
using MinhaArte.Project.Repositories.Interface;
using System;

namespace MinhaArte.Project.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriaModel> Categoria => _context.Categoria;
    }
}