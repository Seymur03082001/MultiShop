using Microsoft.AspNetCore.Mvc;
using MultiShop.ViewModels.Category;

namespace MultiShop.Areas.Areas.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
