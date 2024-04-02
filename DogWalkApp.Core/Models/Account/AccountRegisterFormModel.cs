using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static DogWalkApp.Core.Constants.ErrorMessages;
using static DogWalkApp.Infrastructure.Constants.DataConstants;

namespace DogWalkApp.Core.Models.Account
{
    public class AccountRegisterFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserFirstNameMaxLength,
            MinimumLength = UserFirstNameMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserLastNameMaxLength,
           MinimumLength = UserLastNameMinLength,
           ErrorMessage = LengthMessage)]
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;


    }
}
