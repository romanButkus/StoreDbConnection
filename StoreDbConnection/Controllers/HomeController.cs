using Microsoft.AspNetCore.Mvc;
using StoreDbConnection.BLL.Services;
using StoreDbConnection.Models;
using System.Diagnostics;

namespace StoreDbConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryService _categoryService;

        public HomeController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();

            return View(categories);
        }

        public async Task<IActionResult> Privacy()
        {
            var categories = await _categoryService.GetAllBySort("desc");

            return View(categories);
        }
    }
}
