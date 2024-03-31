using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static DogWalkApp.Infrastructure.Constants.DataConstants;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class City
    {
        [Key]
        [Comment("City's primary identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(CityNameMaxLength)]
        [Comment("Name of the city")]
        public string Name { get; set; } = string.Empty;
    }
}
