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
    public class CastsController : ControllerBase
    {
        private readonly ICastService _castService;

        public CastsController(ICastService castService)
        {
            _castService = castService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCasts()
        {
            var casts = await _castService.GetResponseCasts();

            if (!casts.Any())
            {
                return NotFound("404 NOT FOUND!");
            }
            return Ok(casts);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetCastById(int id)
        {
            var cast = await _castService.GetCastDetailsById(id);

            if (cast != null)
            {
                return Ok(cast);
            }
            return NotFound("404 NOT FOUND!");
        }
     }
}
