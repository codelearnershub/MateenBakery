using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models.ViewModel;
using BakeryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;


namespace BakeryManagementSystem.Controllers
{
    public class CategoryController : Controller
    { 
        public readonly ICategoryService _categoryService;
        public readonly CategoryService categoryService;
        public CategoryController(ICategoryService _categoryService, CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        /*public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryViewModel model)
        {
            _categoryService.Add(model);
            return RedirectToAction("Index");
        }
        /*public IActionResult Find()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _categoryService.Search(id);
            return RedirectToAction("Index");
        }#1#
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateCategoryViewModel model)
        {
            _categoryService.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
        
            var bookings = _categoryService.SearchCategoryById(id);
            if (bookings == null)
            {
                return NotFound();
            }
            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var category = _categoryService.SearchCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }*/

    }
}