using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BulkyBookWeb.Controllers
{   
    //controller Home,  dentro de views tem uma pasta com o mesmo nome
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //action, na pasta Home dentro de view tem um arquivo com o mesmo nome
        public IActionResult Index()
        {
            return View();
        }
        //action, na pasta Home dentro de view tem um arquivo com o mesmo nome
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