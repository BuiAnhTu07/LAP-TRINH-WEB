using Lab3_HienThiSanPham.Models;
using Lab3_HienThiSanPham.ViewModel;
using Lab3_HienThiSanPham.ViewModel.LoginViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        //Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) {
                return View(model);
        }
            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email.Trim());
            if (user == null)
            {
                ModelState.AddModelError("Email", "Tài khoảng không tồn tại");
                return View(model);
            }
            if (user.Password != model.Password.Trim()) {
                ModelState.AddModelError("Password", "Mật khẩu không đúng");
                return View(model);
            }
            var claim = new List<Claim>
            {

            }
}
