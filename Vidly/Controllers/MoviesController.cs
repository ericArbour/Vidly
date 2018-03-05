using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> Movies = new List<Movie>
        {
            new Movie() {Id = 0, Name = "The Big Lebowski"},
            new Movie() {Id = 1, Name = "The Big Lebowski 2: 2 Big 2 Lebowski"},
            new Movie() {Id = 2, Name = "The Big Lebowski 3: Tokyo Drift"}
        };
        public ActionResult Index()
        {
            return View(Movies);
        }

        public ActionResult Details(string id)
        {
            try
            {
                var movie = Movies.First(item => item.Id == int.Parse(id));
                return View(movie);
            }
            catch
            {
                throw new HttpException(404, "No movie.");
            }
        }
    }
}