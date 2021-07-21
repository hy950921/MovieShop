﻿using ApplicationCore.Entities;
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
    public class PurchaseRepository : EfRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Purchase> GetByIdAsync(int id)
        {
            var purchase = await _dbContext.Purchases.Include(p => p.Movie).FirstOrDefaultAsync(p => p.Id == id);

            return purchase;
        }

        public async Task<List<Movie>> GetPurchasedMovieByUser(int userId)
        {
            var movies = await _dbContext.Purchases.Where(p => p.UserId == userId).Include(p => p.Movie).Select(p => p.Movie).ToListAsync();
            return movies;
        }
    }
 
}
