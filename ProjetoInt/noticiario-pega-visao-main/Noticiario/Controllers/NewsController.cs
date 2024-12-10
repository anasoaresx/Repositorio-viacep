using Microsoft.AspNetCore.Mvc;
using Noticiario.Models;

namespace Noticiario.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            List<New> noticia = new List<New>
            {
                new New
                {
                    Id = 1,
                    Title = "Resultado da final da Libertadores 2025",
                    Category = "Esportes",
                    Date = new DateTime(2025, 11, 20),
                    Location = "São Paulo, Brasil"
                }
            };

            return View();
        }
    }
}
