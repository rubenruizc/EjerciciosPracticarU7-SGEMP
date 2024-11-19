using Ejercicio02PracticaU7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio02PracticaU7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Acci�n para la vista Index (ya existente)
        public ActionResult Index()
        {
            // L�gica para determinar el saludo (Buenos d�as, buenas tardes o buenas noches)
            var horaActual = DateTime.Now.Hour;
            string saludo;

            if (horaActual < 12)
                saludo = "�Buenos d�as!";
            else if (horaActual < 18)
                saludo = "�Buenas tardes!";
            else
                saludo = "�Buenas noches!";

            // Enviar saludo, fecha y persona
            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToString("D");

            return View();
        }

        // Acci�n para la vista listadoPersonas
        public ActionResult ListaPersona()
        {
            // Crear una lista de personas
            List<clsPersona> personas = new List<clsPersona>
            {
                new clsPersona { Name = "Juan", Apellido = "P�rez", Id = 30},
                new clsPersona { Name = "Ana", Apellido = "Garc�a", Id = 25},
                new clsPersona { Name = "Luis", Apellido = "Mart�nez", Id = 40},
                new clsPersona { Name = "Maria", Apellido = "L�pez", Id = 35},
                new clsPersona { Name = "Carlos", Apellido = "S�nchez", Id = 28}
            };

            // Enviar el listado a la vista
            return View(personas);
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
