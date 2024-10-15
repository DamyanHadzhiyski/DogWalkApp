using DogWalkApp.Core.Contracts;
using DogWalkApp.Core.Models.Account;
using DogWalkApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace DogWalkApp.Core.Services
{
	public class AccountService : IAccountService
	{
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IUserStore<ApplicationUser> _userStore;

		public AccountService(
			UserManager<ApplicationUser> userManager,
			IUserStore<ApplicationUser> userStore,
			SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_userStore = userStore;
			_signInManager = signInManager;
		}

		public async Task<bool> CreateAccount(AccountRegisterFormModel model)
		{
			var user = CreateUser();

			user.CityId = model.CityId;
			user.FirstName = model.FirstName;
			user.LastName = model.LastName;
			user.District = model.District;

			await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);

			var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				await _signInManager.SignInAsync(user, isPersistent: false);
				return true;
			}

			return false;
		}

		private ApplicationUser CreateUser()
		{
			try
			{
				return Activator.CreateInstance<ApplicationUser>();
			}
			catch
			{
				throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
					$"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
					$"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
			}
		}

		
	}
}
