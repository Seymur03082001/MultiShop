using Microsoft.AspNetCore.Mvc;
using MultiShop.DAL;
using MultiShop.Models;

namespace MultiShop.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DiscountController : Controller
    {
        readonly AppDbContext _context;
        public DiscountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dis = _context.Discounts.ToList();
            return View(dis);
        }
        [HttpGet]
        public IActionResult Create() 
        { 
           return View();
        }
        [HttpPost]
        public IActionResult Create(Discount discount)
        {
            if (discount==null) return NotFound();
            _context.Discounts.Add(discount);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
           Discount discount = _context.Discounts.Find(id);
            if (discount != null) return NotFound();
            _context.Discounts.Remove(discount);
            _context.SaveChanges();
            return RedirectToAction(nameof(Delete));
        }
        public IActionResult Update(int id)
        {
            if (id == null || id == 0) return BadRequest();
            Discount discount = _context.Discounts.Find(id);
            if (discount is null) return NotFound();
            return View(discount);
        }
        public IActionResult Update(int id, Discount discount)
        {
            if (id == null || id == 0 || id != discount.Id) return BadRequest();
            if (!ModelState.IsValid) return View();
            _context.Sliders.Update();
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
            //Slider anotherslider = _context.Sliders.FirstOrDefault(s => s.Order == slider.Order);
            //if (anotherslider != null)
            //{
            //    anotherslider.Order = _context.Sliders.Find(id).Order;
            //}
            Discount exist = _context.Discounts.Find(id);
            exist.Name = discount.Name;
            exist.Percentage = discount.Percentage;

        }
    }
}
