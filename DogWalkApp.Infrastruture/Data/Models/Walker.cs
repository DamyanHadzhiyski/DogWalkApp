using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class Walker
    {
        [Key]
        [Comment("Primary identifier of the dog walker")]
        public int Id { get; set; }

		[Required]
		[Comment("Primary identifier of the user")]
		public string UserId { get; set; } = null!;

		[ForeignKey(nameof(UserId))]
		public ApplicationUser User { get; set; } = null!;

		[Required]
		[Comment("Maximum number of dogs that the walker can handle")]
		public int MaxNumberOfDogs { get; set; }

        [Required]
        [Comment("Dogs weight ranges that the walker accepts")]
        public IEnumerable<WeightRange> WeightRangesLimits { get; set; } = new List<WeightRange>();
    }
}