using Lab3_HienThiSanPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_HienThiSanPham.Controllers
{
    public class AccountController : Controller
    {
        private readonly DbLab3Context _context;

        public AccountController(DbLab3Context context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
