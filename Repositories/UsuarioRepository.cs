using Microsoft.EntityFrameworkCore;
using MinhaArte.Models;
using MinhaArte.Project.Data;
using System;

namespace MinhaArte.Project.Repositories
{
    public class UsuarioRepository
    {
        private readonly ApplicationDbContext _context;
        public UsuarioRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<UsuarioModel> Usuario => _context.Usuario.Include(c => c.Quadros);
        public UsuarioModel GetUsuarioModelById(int usuarioId)
        {
            return _context.Usuario.FirstOrDefault(u => u.UsuarioId == usuarioId);
        }
    }
}