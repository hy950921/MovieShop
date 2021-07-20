using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
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
    public class AccountController : ControllerBase
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                // save to db, register user
                var createdUser = await _userService.RegisterUser(model);
                // 201 Created
                return Ok(createdUser);
            }
            // 400
            return BadRequest("Please check the data you entered");
        }

        //[HttpGet]
        //[Route("{id: int}")]




    }
}
