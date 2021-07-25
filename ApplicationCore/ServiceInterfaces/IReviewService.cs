using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IReviewService
    {
        Task<List<ReviewResponseModel>> GetReviewsByUserId(int id);
        Task<Review> WriteReview(ReviewRequestModel model);
        Task<Review> UpdateReview(ReviewRequestModel model);
    }
}
