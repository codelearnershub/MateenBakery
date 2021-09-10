using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystem.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}