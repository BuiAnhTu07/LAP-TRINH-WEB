using System.Diagnostics;
using Lab3_HienThiSanPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_HienThiSanPham.Controllers
{
    public class HomeController : Controller
    {

        private readonly DbLab3Context _context;
        public HomeController(DbLab3Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> product = _context.Products.ToList();
            return View(product);
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
