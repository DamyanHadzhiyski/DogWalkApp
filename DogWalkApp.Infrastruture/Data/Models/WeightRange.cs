using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class WeightRange
    {
        [Key]
        [Comment("Primary identifier of the weight range")]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
