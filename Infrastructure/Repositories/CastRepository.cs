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
    public class CastRepository : EfRepository<Cast>, ICastRepository
    {
        public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Cast>> GetAllCastsAsync()
        {
            var casts = await _dbContext.Casts.Take(20).ToListAsync();

            return casts;
        }

        public async Task<Cast> GetCastByIdAsync(int id)
        {
            var cast = await _dbContext.Casts.Include(c=>c.MovieCasts).FirstOrDefaultAsync(c => c.Id == id);

            return cast;
        }
    }
}
