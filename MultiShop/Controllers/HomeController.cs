using Microsoft.AspNetCore.Mvc;
using MultiShop.DAL;
using System;

namespace MultiShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
