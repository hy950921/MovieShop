using ApplicationCore.Entities;
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
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public Task<List<ReviewResponseModel>> GetReviewsByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Review> UpdateReview(ReviewRequestModel model)
        {
            var review = new Review
            {
                MovieId = model.MovieId,
                UserId = model.UserId,
                Rating = model.Rating,
                ReviewText = model.ReviewText
            };
            return await _reviewRepository.UpdateAsync(review);
        }

        public async Task<Review> WriteReview(ReviewRequestModel requestModel)
        {
            var review = new Review
            {
                UserId = requestModel.UserId,
                MovieId = requestModel.MovieId,
                Rating = requestModel.Rating,
                ReviewText = requestModel.ReviewText
            };
            return await _reviewRepository.AddAsync(review);
        }
    }
}
