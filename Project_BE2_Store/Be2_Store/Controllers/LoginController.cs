using BusinessObject.BusinessObject;
using DataAccess.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace Be2_Store.Controllers
{
    public class LoginController : Controller
    {
        IAccountReponsitory accountRepository;
        public LoginController(IAccountReponsitory accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var login = accountRepository.Authenticate(username, password);
            if (login == true)
            {
                return RedirectToAction("HomePage", "Home");
                HttpContext.Session.SetString("UserName", username);
            }
            ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không chính xác";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Account account)
        {
            var signup = accountRepository.AddAccount(account);
            
            return View("Login", "Login");
        }
    }
}
