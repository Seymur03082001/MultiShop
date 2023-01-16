using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Areas.Areas.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
