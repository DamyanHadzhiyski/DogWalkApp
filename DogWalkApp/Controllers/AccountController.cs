﻿using Microsoft.AspNetCore.Mvc;

namespace DogWalkApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
