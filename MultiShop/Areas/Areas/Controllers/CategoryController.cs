using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.Areas.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
