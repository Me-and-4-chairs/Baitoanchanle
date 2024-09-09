using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_v2.Models;

namespace web_v2.Controllers
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

        [HttpPost]
        public IActionResult KiemTra(string so)
        {
            var result = ProcessKiemTra(so);
            ViewBag.Result = result; // Sử dụng ViewBag để truyền kết quả đến View
            return View("Index"); // Trả về View Index với kết quả kiểm tra
        }

        private string ProcessKiemTra(string so)
        {
            if (int.TryParse(so, out int number))
            {
                if (number % 2 == 0)
                {
                    return $"{number} là số chẵn!";
                }
                else
                {
                    return $"{number} là số lẻ!";
                }
            }
            else
            {
                return "Vui lòng nhập một số hợp lệ.";
            }
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
