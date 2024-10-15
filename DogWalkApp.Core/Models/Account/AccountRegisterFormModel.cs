using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [DisplayName("City")]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public IEnumerable<CityInformationModel> Cities { get; set; } = new List<CityInformationModel>();

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(UserDistrictMaxLength,
            MinimumLength = UserDistrictMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("District")]
        public string District { get; set; } = string.Empty;
    }
}
