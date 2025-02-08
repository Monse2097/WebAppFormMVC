using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppFormMVC.Models;

namespace WebAppFormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Submit(ContactMessage model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            _context.ContactMessage.Add(model);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Tu mensaje ha sido enviado con éxito";

                return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
