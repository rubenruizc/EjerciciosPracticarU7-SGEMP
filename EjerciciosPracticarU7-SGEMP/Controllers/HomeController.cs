using EjerciciosPracticarU7_SGEMP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjerciciosPracticarU7_SGEMP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            clsPersona persona = new clsPersona(1,"Ruben","Ruiz",new DateTime(2005,4,15));

            DateTime horaActual = DateTime.Now;

            ViewData["Saludo"] = horaActual.Hour > 12 ? "Buenas tardes" : horaActual.Hour > 20 ? "Buenas noches" : "Buenos días";

            ViewBag.HoraActual = horaActual.ToLongDateString();

            ViewBag.Id = persona.Id;
            ViewBag.Nombre = persona.Name;
            ViewBag.Apellido = persona.Apellido;
            ViewBag.FechaNac = persona.fechaNacimiento;



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
