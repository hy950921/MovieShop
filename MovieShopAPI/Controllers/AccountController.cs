using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AccountController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegisterRequestModel model)
        {
            var createdUser = await _userService.RegisterUser(model);

            // send the URL for newly created user also
            // 5000

            return CreatedAtRoute("GetUser", new { id = createdUser.Id }, createdUser);

            // 201
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetUser")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound($"User does not exists for {id}");
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();

            if (!users.Any())
            {
                return NotFound("404 NOT FOUND");
            }
            return Ok(users);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestModel model)
        {
            //check if the user has entered correct un/pw
            var user = await _userService.Login(model.Email, model.Password);
            if (user == null)
            {
                return Unauthorized("Please enter correct user email and password");
            }
            string dateInput = "Jan 1, 1990";
            var parsedDate = DateTime.Parse(dateInput);
            user.DateOfBirth = parsedDate;
            //create jwt token
            var jwtToken = GenerateJWT(user);

            return Ok(new { token = jwtToken });
        }

        private string GenerateJWT(UserLoginResponseModel model)
        {
            // we will use the token library to create token
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, model.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, model.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, model.FirstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, model.LastName)
            };

            // create identity object and sotre claims
            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);


            // read the secret key from appsettings,json, make sure secret key is unique and not guessable
            // in real world we use something like Azure keyVault to store any secrets of application

            var secretKey = _configuration.GetValue<string>("JwtSettings:SecretKey");
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            // get the expiration time
            var expires = DateTime.UtcNow.AddDays(_configuration.GetValue<int>("JwtSettings:Expiration"));

            // pick an hashing algorithm

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);


            //create the token object, you will use to create the token that will include all the information
            // such as credentials, claims, expiration time
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = identityClaims,
                Expires = expires,
                SigningCredentials = credentials,
                Issuer = _configuration.GetValue<string>("JwtSettings:Issuer"),
                Audience = _configuration.GetValue<string>("JwtSettings:Audience")
            };

            var encodedJwt = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(encodedJwt);
        }

    }
}
