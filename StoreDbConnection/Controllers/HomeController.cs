using Microsoft.AspNetCore.Mvc;
using StoreDbConnection.BLL.Services;

namespace StoreDbConnection.Controllers
{

    public class HomeController : Controller
    {
        private const int ITEMS_PER_PAGE = 2;
        private readonly CategoryService _categoryService;

        public HomeController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int id = 0)
        {
            var categories = await _categoryService.GetAllAsync();

            ViewBag.PageCount = (int)Math.Ceiling(categories.Count() / (double)ITEMS_PER_PAGE);

            return View(categories.Skip((id - 1) * ITEMS_PER_PAGE).Take(ITEMS_PER_PAGE));
        }

        public async Task<IActionResult> Privacy()
        {

            var categories = await _categoryService.GetAllBySort("desc");

            return View(categories);
        }
    }
}
