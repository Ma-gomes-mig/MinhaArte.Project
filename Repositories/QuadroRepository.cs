using Microsoft.EntityFrameworkCore;
using MinhaArte.Models;
using MinhaArte.Project.Data;
using System;

namespace MinhaArte.Project.Repositories
{
    public class QuadroRepository
    {
        private readonly ApplicationDbContext _context;
        public QuadroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<QuadroModel> Quadro => _context.Quadro.Include(c => c.Categoria);

        public IEnumerable<QuadroModel> QuadroFavorito => _context.Quadro.Where(q => q.IsPreferido);

        public IEnumerable<QuadroModel> QuadroDisponivel => _context.Quadro.Where(q => q.Disponivel);

        public QuadroModel GetQuadroModelById(int QuadroId)
        {
            return _context.Quadro.FirstOrDefault(u => u.QuadroId == QuadroId);
        }
    }
}
