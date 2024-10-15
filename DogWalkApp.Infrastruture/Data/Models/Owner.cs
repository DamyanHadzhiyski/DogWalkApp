using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DogWalkApp.Infrastructure.Data.Models
{
    public class Owner
    {
        [Key]
        [Comment("Primary identifier of the dog owner")]
        public int Id { get; set; }

        [Required]
        [Comment("Primary identifier of the user")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("List with the dogs the owner has")]
        public IEnumerable<Dog> Dogs { get; set; } = new List<Dog>();
    }
}