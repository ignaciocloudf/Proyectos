using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IRepositorioProyectos _repositorioProyectos;
		private readonly IServicioEmailBrevo _servicioEmail;

		public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyecto, IServicioEmailBrevo servicioEmail)
		{
			_logger = logger;
			_repositorioProyectos = repositorioProyecto;
			_servicioEmail = servicioEmail;
		}

		public IActionResult Index()
		{
			_logger.LogCritical("Este es un mensaje de Ilogger");
			var proyectos = _repositorioProyectos.ObtenerProyectos().Take(3).ToList();
			var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
			return View(modelo);
		}

		
		public IActionResult Proyectos()
		{
			var proyectos = _repositorioProyectos.ObtenerProyectos();
			return View(proyectos);
		}

		public IActionResult Contacto()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Contacto(Contacto contacto)
		{
			await _servicioEmail.Enviar(contacto);
			return RedirectToAction("Gracias");
		}

		public IActionResult Gracias()
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
