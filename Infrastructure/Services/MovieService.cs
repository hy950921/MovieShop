using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<MovieCardResponseModel>> GetTopBudgetMovies()
        {
            var movies = await _movieRepository.GetHighest10BudgetMovies();
            List<MovieCardResponseModel> res = new List<MovieCardResponseModel>();
            foreach (var m in movies)
            {
                res.Add(new MovieCardResponseModel
                {
                    Id = m.Id,
                    Budget = m.Budget.GetValueOrDefault(),
                    Title = m.Title,
                    PosterUrl = m.PosterUrl
                });
            }
            return res;
        }

        public async Task<List<MovieCardResponseModel>> GetTopRevenueMovies()
        {
            var movies = await _movieRepository.GetHighest30GrossingMovies();

            var movieCards = new List<MovieCardResponseModel>();
            foreach (var m in movies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = m.Id,
                    Budget = m.Budget.GetValueOrDefault(),
                    Title = m.Title,
                    PosterUrl = m.PosterUrl
                });
            }
            return movieCards;
        }

        
    }
}
