using DogWalkApp.Infrastructure.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DogWalkApp.Infrastructure.Constants.DataConstants;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class Dog
    {
        [Key]
        [Comment("Primary identifier of the dog")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DogNameMaxLength)]
        [Comment("Dog's name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Dog's birth date")]
        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime Birthdate { get; set; }

        [Required]
        [MaxLength(DogBreedMaxLength)]
        [Comment("Dog's breed")]
        public string Breed { get; set; } = string.Empty;

        [Required]
        [Comment("Dog's sex - male/female")]
        public Sex Sex { get; set; }

        [Required]
        [Comment("Dog's weight in accepted ranges")]
        public WeightLimit Weight { get; set; }

        [Comment("Special needs of the dog")]
        public string SpecialNotes { get; set; } = string.Empty;

        [Required]
        [Comment("Dog's owner primary identifier")]
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; } = null!;
    }
}
