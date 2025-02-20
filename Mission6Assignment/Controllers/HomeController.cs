using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6Assignment.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        // get the instance of a form
        private FormContext _context;

        public HomeController(FormContext temp)
        {
            _context = temp;
        }

        // get the view index
        public IActionResult Index()
        {
            return View();
        }

        // get the view KnowJoel
        public IActionResult KnowJoel()
        {
            return View();
        }

        // get route for the movie form that takes in categoryname from the category table
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("MovieForm", new Form());
        }

        // Post route for the movie form that adds a movie to the database
        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirm", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();
                return View(response);
            }
            
        }

        // get route for show movies that includes the category table
        public IActionResult ShowMovies()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        // get route for edit that gets a MovieId and also takes categoryName from the category table
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", recordToEdit);

        }

        // post route to edit and update a form into the database
        [HttpPost]
        public IActionResult Edit(Form updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("ShowMovies");
        }

        // get route for the delete action that takes in the movieId
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        // post route that takes a movie form and deletes it
        [HttpPost]
        public IActionResult Delete(Form movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ShowMovies");
        }
    }
}
