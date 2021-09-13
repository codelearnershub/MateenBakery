using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}