using FaturaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FaturaWebApp.Controllers
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
            //veri tabanından fatura listesi modeli ile verileri alıyorum
            var faturalar = DbContex.VeriOku();

            //aldıgım modeli view gönderiyorum

















            return View(faturalar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}