using Microsoft.AspNetCore.Mvc;
using calculoDeCombustivel.Models;

namespace calculoDeCombustivel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new CombustivelModel());
        }

        [HttpPost]
        public IActionResult Index(CombustivelModel model)
        {
            if (ModelState.IsValid)
            {
                model.Indice = model.Gasolina / model.Etanol;

                if (model.Indice < 0.7m)
                {
                    model.Resultado = "Compensa abastecer com ETANOL! 🌱";
                }
                else
                {
                    model.Resultado = "A GASOLINA é a melhor opção! ⛽";
                }
            }

            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
