//using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TuplePostingandCapturing.Models;

namespace TuplePostingandCapturing.Controllers
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

        public IActionResult CreateProduct()
        {
            var touple = (new Product() , new User() );
            return View(touple);
        }

        [HttpPost]
        //touple nesnlenirini binding etmek ucun Bint Atributundan istifade edirik 
        public IActionResult CreateProduct([Bind(Prefix = "Item1")]Product product, [Bind(Prefix = "Item2")] User user)
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