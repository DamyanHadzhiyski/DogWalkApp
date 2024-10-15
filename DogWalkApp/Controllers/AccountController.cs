using DogWalkApp.Core.Contracts;
using DogWalkApp.Core.Models.Account;
using DogWalkApp.Core.Services;
using DogWalkApp.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DogWalkApp.Controllers
{
	public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAccountService _account;

        public AccountController(ApplicationDbContext context, IAccountService account)
        {
            _context = context;
            _account = account;
        }


        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var model = new AccountRegisterFormModel();

            var cities = await _context.Cities
                .Select(c => new CityInformationModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            ViewBag.Cities = new SelectList(cities, "Id", "Name");

            if(User.Identity?.IsAuthenticated == false)
            {
                return View(model);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterFormModel model)
        {
			if (ModelState.IsValid)
            {
                await _account.CreateAccount(model);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
