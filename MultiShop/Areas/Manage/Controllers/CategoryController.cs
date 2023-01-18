using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.Areas.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryVm)
        {
            return View();
        }
    }
}
