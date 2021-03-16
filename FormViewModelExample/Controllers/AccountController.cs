using FormViewModelExample.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FormViewModelExample.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("/login")]
        public IActionResult Login()
        {
            AccountLoginVm vm = new AccountLoginVm();
            vm.Email = "Test";
            vm.Password = "123";
            return View(vm);
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(AccountLoginVm accountLoginVm)
        {
            return RedirectToAction("contact", "home");
        }

        [HttpGet]
        [Route("/admin/home")]
        public IActionResult AdminHomepage()
        {
            return Content("You are logged in!");
        }


    }
}
