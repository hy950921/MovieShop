﻿using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class CastsController : Controller
    {
        private readonly ICastService _castService;

        public CastsController(ICastService castService)
        {
            _castService = castService;
        }

        public async Task<IActionResult> Index()
        {
            var casts = await _castService.GetResponseCasts();
            return View(casts);
        }

        public async Task<IActionResult> CastDetails(int id)
        {
            var cast = await _castService.GetCastDetailsById(id);

            return View(cast);
        }

        
    }
}
