using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logging;

        public AccountController(ILogger<AccountController> logging)
        {
            _logging = logging;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorVM { 
                regId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            }
            );
        }

        [HttpPost]
        public ActionResult Register(Registration model)
        {
            if (ModelState.IsValid)
            {
                if (model.Confirm())
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            Registration model = new Registration();
            return View(model);
        }        
    }
}
