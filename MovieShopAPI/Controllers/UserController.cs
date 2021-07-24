﻿using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;
        private readonly IUserService _userService;

        public UserController(IPurchaseService purchaseService, IUserService userService)
        {
            _purchaseService = purchaseService;
            _userService = userService;
        }

        [HttpGet]
        [Route("purchases")]
        public async Task<IActionResult> GetUserPurchasedMovies(int userId)
        {

            var purchases = await _purchaseService.GetAllPurchasedMovie(userId);
            return Ok(purchases);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("404 NOT FOUND USER");
        }


        [HttpGet]
        [Route("{id:int}/reviews")]
        public async Task<IActionResult> GetReviews(int id)
        {
            var reviews = await _userService.GetReviewsByUserId(id);
            if(!reviews.Any())
            {
                return NotFound("404 NOT FOUND");
            }
            return Ok(reviews);
        }
    }
}
