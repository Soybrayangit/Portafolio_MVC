using Microsoft.AspNetCore.Mvc;
using MVC_portafolio.Models;
using System.Diagnostics;

namespace MVC_portafolio.Controllers
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
			return View();
		}
		public IActionResult Bienvenido()
		{
			return View();
		 }
        public IActionResult Pilares()
        {
			return View();
        }
        public IActionResult Aprendido()
        {
			return View();
        }
        public IActionResult Datos()
        {
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