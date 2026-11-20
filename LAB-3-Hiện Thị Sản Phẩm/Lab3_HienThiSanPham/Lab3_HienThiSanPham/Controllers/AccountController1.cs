using Lab3_HienThiSanPham.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_HienThiSanPham.Controllers
{
    public class AccountController1 : Controller
    {
        private readonly DbLab3Context _context;

        public AccountController1(DbLab3Context context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
