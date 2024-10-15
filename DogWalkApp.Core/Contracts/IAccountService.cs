using DogWalkApp.Core.Models.Account;

namespace DogWalkApp.Core.Contracts
{
	public interface IAccountService
	{
		Task<bool> CreateAccount(AccountRegisterFormModel model);
	}
}
