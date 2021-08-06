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

        public async Task<List<MovieCardResponseModel>> GetAllMovies()
        {
            var movies = await _movieRepository.ListAllAsync();

            var moviesResponse = new List<MovieCardResponseModel>();

            foreach (var movie in movies)
            {
                moviesResponse.Add(new MovieCardResponseModel
                {

                    Id = movie.Id,
                    Title = movie.Title,
                    Budget = movie.Budget.GetValueOrDefault(),
                    PosterUrl = movie.PosterUrl,
                    
                });
            }
            return moviesResponse;
        }

        public async Task<MovieDetailsResponseModel> GetMovieDetails(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);

            var movieDetails = new MovieDetailsResponseModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Budget = movie.Budget.GetValueOrDefault(),
                PosterUrl = movie.PosterUrl,
                BackdropUrl = movie.BackdropUrl,
                Tagline = movie.Tagline,
                RunTime = movie.RunTime,
                ReleaseDate = movie.ReleaseDate,
                Rating = movie.Rating,
                Overview = movie.Overview
            };

            movieDetails.Casts = new List<CastResponseModel>();

            foreach (var cast in movie.MovieCasts)
            {
                movieDetails.Casts.Add(new CastResponseModel
                {
                    Id = cast.CastId,
                    Name = cast.Cast.Name,
                    Character = cast.Character,
                    ProfilePath = cast.Cast.ProfilePath
                });
            }

            movieDetails.Genres = new List<GenreModel>();
            foreach (var genre in movie.MovieGenres)
            {
                if(genre != null )
                {
                    movieDetails.Genres.Add(
                        new GenreModel
                        {
                            Id = genre.Genre.Id,
                            Name = genre.Genre.Name
                        });
                }
            }
            return movieDetails;
        }

        public async Task<List<MovieCardResponseModel>> GetTopRatedMovies()
        {
            var movies = await _movieRepository.GetHighest30RatedMovies();
            var movieCards = new List<MovieCardResponseModel>();
            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Budget = movie.Budget.GetValueOrDefault(),
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }
            return movieCards;
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
