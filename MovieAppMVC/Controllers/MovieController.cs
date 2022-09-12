using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieAppMVC.DAL;

namespace MovieAppMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDBContext _db;
        public MovieController(MovieDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var movies = _db.Movies.Include("Category").ToList();
            // return View(_db.Movies.ToList());
            return View(movies);

        }
        //public List<Movie> GetMovie()
        //{
        //    var movies = _db.Movies.ToList();
        //    return _db.Movies.ToList();

        //}
        public IActionResult Add()
        {
            GetCategorySelectList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(MovieVM movie)
        {
            if (ModelState.IsValid)
            {
                var _movie = new Movie();

                _movie.MovieName = movie.MovieName;
                _movie.Director = movie.Director;
                _movie.CategoryId = movie.CategoryId;
                _movie.ReleasedYear = movie.ReleasedYear;
                _movie.Duration = movie.Duration;
                _db.Add(_movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Delete(int Id)
        {
            var movie = _db.Movies.Find(Id);
            if (movie != null)
            {
                _db.Movies.Remove(movie);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
        public IActionResult Update(int Id)
        {
            var movie = _db.Movies.Find(Id);
            GetCategorySelectList();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Update(int Id, Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (Id == movie.Id)
                {
                    Movie _movie = new Movie();
                    //_movie.Id = Id;
                    //_movie.MovieName = movie.MovieName;
                    //_movie.Director = movie.Director;
                    //_movie.CategoryId = movie.CategoryId;
                    //_movie.Duration = movie.Duration;
                    //_movie.ReleasedYear = movie.ReleasedYear;
                    _db.Entry(movie).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }          
            GetCategorySelectList();
            return View(movie);
        }
        private void GetCategorySelectList()
        {
            ViewBag.Categories = new SelectList(_db.Categories.ToList(), "Id", "CategoryName");
        }

    }
}
