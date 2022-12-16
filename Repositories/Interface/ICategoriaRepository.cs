using MinhaArte.Models;
using System.Collections.Generic;

namespace MinhaArte.Project.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<CategoriaModel> Categoria { get; }
    }
}
