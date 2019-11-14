using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testeMVC.Models;


namespace testeMVC.Controllers
{
    [Route("web/[controller]/[action]")] //Essa sobrepoe o que está na classe startup.cs
    public class Teste : Controller
    {
        private readonly ILogger<Teste> _logger;

        public Teste(ILogger<Teste> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult People(){
            People p = new People("Alan", 37); 
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
