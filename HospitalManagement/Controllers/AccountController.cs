using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    public class AccountController : Controller
    {
        // عرض صفحة تسجيل الدخول
        public IActionResult Login()
        {
            return View();
        }

        // تنفيذ تسجيل الدخول
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123456")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}