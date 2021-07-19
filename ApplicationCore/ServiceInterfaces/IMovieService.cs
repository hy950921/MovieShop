using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieCardResponseModel>> GetTopRevenueMovies();   // response method to get top 30 movie DTO => map properties between entity and model

        Task<MovieDetailsResponseModel> GetMovieDetails(int id);    // response method to get details of a single movie model
    }
}
