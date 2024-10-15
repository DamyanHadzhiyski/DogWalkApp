using DogWalkApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DogWalkApp.Infrastructure.Data.Configurations
{
    public class WalkerConfiguration : IEntityTypeConfiguration<Walker>
    {
        public void Configure(EntityTypeBuilder<Walker> builder)
        {
         
        }
    }
}
