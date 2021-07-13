using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            MovieService ms = new MovieService();
            var movies = ms.GetTopRevenueMovies();

            return View(movies);
        }
    }
}
