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

        // Acción para la vista Index (ya existente)
        public ActionResult Index()
        {
            // Lógica para determinar el saludo (Buenos días, buenas tardes o buenas noches)
            var horaActual = DateTime.Now.Hour;
            string saludo;

            if (horaActual < 12)
                saludo = "¡Buenos días!";
            else if (horaActual < 18)
                saludo = "¡Buenas tardes!";
            else
                saludo = "¡Buenas noches!";

            // Enviar saludo, fecha y persona
            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToString("D");

            return View();
        }

        // Acción para la vista listadoPersonas
        public ActionResult ListaPersona()
        {
            // Crear una lista de personas
            List<clsPersona> personas = new List<clsPersona>
            {
                new clsPersona { Name = "Juan", Apellido = "Pérez", Id = 30},
                new clsPersona { Name = "Ana", Apellido = "García", Id = 25},
                new clsPersona { Name = "Luis", Apellido = "Martínez", Id = 40},
                new clsPersona { Name = "Maria", Apellido = "López", Id = 35},
                new clsPersona { Name = "Carlos", Apellido = "Sánchez", Id = 28}
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
