using bubituzagi.Data;
using bubituzagi.Models;
using bubituzagi.Models;
using bubituzagi.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace bubituzagi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

            
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Posts.Include(p => p.Catogory).Include(p=>p.Author);
            return View(applicationDbContext.ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Hakkimizda()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}