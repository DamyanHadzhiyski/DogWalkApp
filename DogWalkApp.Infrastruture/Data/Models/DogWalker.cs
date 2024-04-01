using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class DogWalker
    {
        [Key]
        [Comment("Primary identifier of the dog walker")]
        public int Id { get; set; }

        [Required]
        public int MaxDogsToWalk { get; set; }

        [Required]
        [Comment("Primary identifier of the user")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("List with the dogs in weight ranges that the walker accepts")]
        public IEnumerable<WeightRange> AcceptableWeightRanges { get; set; } = new List<WeightRange>();
    }
}