using Microsoft.AspNetCore.Mvc;
using MinhaArte.Project.Repositories;
using MinhaArte.Project.Repositories.Interface;

namespace MinhaArte.Project.Controllers
{
    public class QuadroController : Controller
    {
        private readonly IQuadroRepository _quadroRepository;
        public QuadroController(IQuadroRepository quadroRepository)
        {
            _quadroRepository = quadroRepository;

        }
        public IActionResult List()
        {
            var quadro = _quadroRepository.Quadro;
            return View(quadro);
        }
    }
}
