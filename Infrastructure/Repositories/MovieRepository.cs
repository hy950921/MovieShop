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

        public async Task<List<Movie>> GetHighest10BudgetMovies()
        {
            var res = await _dbContext.Movies.OrderByDescending(m => m.Budget).Take(10).ToListAsync();

            return res;
        }

        public async Task<List<Movie>> GetHighest30GrossingMovies()
        {
            var res = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();

            return res;
        }
        
    }
}
