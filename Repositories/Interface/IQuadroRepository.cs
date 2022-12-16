using MinhaArte.Models;

namespace MinhaArte.Project.Repositories.Interface
{
    public interface IQuadroRepository
    {
        IEnumerable<QuadroModel> Quadro { get; }
        IEnumerable<QuadroModel> QuadroFavorito { get; }
        IEnumerable<QuadroModel> QuadroDisponivel { get; }
        QuadroModel GetQuadroModelById(int QuadroId);

    }
}