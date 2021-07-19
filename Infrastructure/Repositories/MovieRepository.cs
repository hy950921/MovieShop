using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository, IAsyncRepository<Movie>
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<List<Movie>> GetHighest30GrossingMovies()
        {
            var res = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();

            return res;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            var movie = await _dbContext.Movies.Include(m => m.MovieCasts).ThenInclude(m => m.Cast)
                        .Include(m => m.MovieGenres).ThenInclude(m => m.Genre).FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                throw new Exception($"no movie found with {id}");
            }

            var movieRating = await _dbContext.Reviews.Where(m => m.MovieId == id).AverageAsync(r => r == null ? 0 : r.Rating);

            if (movieRating > 0)
            {
                movie.Rating = movieRating;
            }
            return movie;
        }

    }
}
