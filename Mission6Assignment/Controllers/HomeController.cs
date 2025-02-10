using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6Assignment.Models;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        private FormContext _context;

        public HomeController(FormContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirm", response);
        }
    }
}
