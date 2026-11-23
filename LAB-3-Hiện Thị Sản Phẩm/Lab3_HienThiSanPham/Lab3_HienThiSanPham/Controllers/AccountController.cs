using Lab3_HienThiSanPham.Models;
using Lab3_HienThiSanPham.ViewModel;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userExisting = _context.Users.FirstOrDefault(u => u.Email == model.Email);
                if (userExisting != null)
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại.");
                    return View(model);
                }
                else
                {
                    var user = new User
                    {
                        Fullname = model.FullName,
                        Email = model.Email,
                        Password = model.Password,
                        IsAdmin = false,
                        RegisterData = DateTime.Now,
                    };
                    _context.Users.Add(user);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
