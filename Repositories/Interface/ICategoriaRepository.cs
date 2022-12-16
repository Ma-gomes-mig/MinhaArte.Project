using MinhaArte.Models;
using MinhaArte.Project.Repositories;
using System.Collections.Generic;

namespace MinhaArte.Project.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<CategoriaModel> Categoria { get; }
    }
}
