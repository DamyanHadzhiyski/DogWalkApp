using DogWalkApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogWalkApp.Infrastructure.Data.Configurations
{
    public class DogOwnerConfiguration : IEntityTypeConfiguration<DogOwner>
    {
        public void Configure(EntityTypeBuilder<DogOwner> builder)
        {
            builder
                .HasMany(o => o.Dogs)
                .WithOne(d => d.Owner)
                .HasForeignKey(o => o.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
