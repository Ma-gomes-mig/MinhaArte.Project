using MinhaArte.Models;
using MinhaArte.Project.Repositories;
using System.Collections.Generic;

namespace MinhaArte.Project.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioModel> Usuario { get; }
        UsuarioModel GetUsuarioModelById(int id);
    }
}