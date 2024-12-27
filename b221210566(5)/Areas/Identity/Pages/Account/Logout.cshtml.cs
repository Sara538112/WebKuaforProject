// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using b221210566_5_.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace b221210566_5_.Areas.Identity.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<User> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            _logger.LogInformation("Logging out user...");

            // Sign out the user
            await _signInManager.SignOutAsync();

            // Log the successful logout
            _logger.LogInformation("User logged out successfully.");

            // Check if returnUrl is provided and return accordingly
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl); // Redirect to the provided return URL
            }
            else
            {
                // Redirect to Home/Index page after logout
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
