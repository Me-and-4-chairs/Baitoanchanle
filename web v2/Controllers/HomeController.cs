using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_v2.Models;
using lib_chanle; // Thay thế bằng không gian tên của DLL bạn đang sử dụng

namespace web_v2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly kiemtra _checker; // Lớp từ DLL

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _checker = new kiemtra(); // Khởi tạo đối tượng từ DLL
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KiemTra(string so)
        {
            try
            {
                var result = ProcessKiemTra(so);
                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                _logger.LogError(ex, "Lỗi khi kiểm tra số.");
                ViewBag.Result = "Đã xảy ra lỗi. Vui lòng thử lại.";
            }
            return View("Index");
        }

        private string ProcessKiemTra(string so)
        {
            if (int.TryParse(so, out int number))
            {
                // Sử dụng phương thức từ lớp kiemtra
                var result = _checker.Main(number);
                return result;
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
