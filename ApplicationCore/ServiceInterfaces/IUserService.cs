using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserRegisterResponseModel> RegisterUser(UserRegisterRequestModel requestModel);

        Task<UserLoginResponseModel> Login(string email, string password);


        // Get User Details
        Task<UserLoginResponseModel> GetUserDetails(int id);

        Task<UserLoginResponseModel> GetUserById(int id);
        Task<List<UserLoginResponseModel>> GetAllUsers();

        Task<List<MovieCardResponseModel>> GetFavoriteMoviesByUserAsync(int userId);

    }
}
