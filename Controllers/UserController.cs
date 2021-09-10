using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}