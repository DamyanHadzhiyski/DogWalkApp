using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DogWalkApp.Infrastructure.Constants.DataConstants;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        [Comment("User's first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        [Comment("User's last name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("User's city")]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        [Required]
        [MaxLength(UserDistrictMaxLength)]
        [Comment("User's city district")]
        public string District { get; set; } = string.Empty;

        public IEnumerable<Dog> Dogs { get; set; } = new List<Dog>();
    }
}
