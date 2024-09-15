using CentalWebsiteFrontToBack.DAL;
using CentalWebsiteFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CentalWebsiteFrontToBack.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        private readonly int _categoryCount;

        public HomeController(AppDbContext context)
        {
            _context = context;
            _categoryCount = _context.Categories.Count();
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.CategoryCount = _categoryCount;

            var categories=await _context.Categories.Take(1).ToListAsync();
            
            return View(categories);
        }

        public IActionResult loadCategories(int skip)
        {
            if (skip >= _categoryCount)
            {
                return BadRequest();
            }
            var categories = _context.Categories.Skip(skip).Take(1).ToList();

            return PartialView("_HomePartial", categories);
        }
    }
}
