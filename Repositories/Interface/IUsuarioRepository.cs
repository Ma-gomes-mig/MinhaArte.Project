using MinhaArte.Models;

namespace MinhaArte.Project.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioModel> Usuario { get; }
        UsuarioModel GetUsuarioModelById(int id);
    }
}