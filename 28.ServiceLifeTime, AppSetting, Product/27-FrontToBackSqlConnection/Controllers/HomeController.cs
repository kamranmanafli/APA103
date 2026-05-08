using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Controllers
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

            List<Slider> sliders = _context.Sliders
                .OrderBy(s => s.Order)
                .Take(2)
                .Where(s => !s.IsDeleted)
                .ToList();

            List<Product> products= _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p=>p.ProductImages)
                .ToList();

            HomeVM homeVM = new()
            {
                Sliders = sliders,
                Products = products
            };

            return View(homeVM);
        }


    }
}
