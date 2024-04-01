using DogWalkApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogWalkApp.Infrastructure.Data.Configurations
{
    public class DogWalkerConfiguration : IEntityTypeConfiguration<DogWalker>
    {
        public void Configure(EntityTypeBuilder<DogWalker> builder)
        {
         
        }
    }
}
