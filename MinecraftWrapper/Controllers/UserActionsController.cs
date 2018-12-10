﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MinecraftWrapper.Data;
using MinecraftWrapper.Models;
using MinecraftWrapper.Services;

namespace MinecraftWrapper.Controllers
{
    [Authorize]
    public class UserActionsController : Controller
    {
        private readonly ConsoleApplicationWrapper _wrapper;
        private readonly UserRepository _userRepository;
        private readonly UserManager<AuthorizedUser> _userManager;

        public UserActionsController ( ConsoleApplicationWrapper wrapper, UserRepository userRepository, UserManager<AuthorizedUser> userManager )
        {
            _wrapper = wrapper;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult UpdateTickingArea ()
        {
            return View ( new UpdateTickingAreaViewModel () );
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTickingArea ( UpdateTickingAreaViewModel model )
        {
            var user = await _userManager.GetUserAsync ( HttpContext.User );
            var data = _userRepository.GetAdditionalUserDataByUserId ( user.Id );

            if ( string.IsNullOrEmpty ( data?.GamerTag ) )
            {
                ModelState.AddModelError ( "", "An Xbox Live gamertag is required to use this function." );
            }
            else
            {
                _wrapper.SendInput ( $"tickingarea remove {data.GamerTag}" );
                _wrapper.SendInput ( $"execute {data.GamerTag} ~ ~ ~ tickingarea add circle {model.XCoord} 0 {model.ZCoord} 1 {data.GamerTag}" );

                ViewBag.Status = "Update sent to server.";
            }

            return View ();
        }
    }
}