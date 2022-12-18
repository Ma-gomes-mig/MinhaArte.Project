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
            var TotalQuadro = quadro.Count();

            ViewBag.Total = "O total de quadros é: ";
            ViewBag.TotalQuadro = TotalQuadro;
            return View(quadro);
        }
    }
}
