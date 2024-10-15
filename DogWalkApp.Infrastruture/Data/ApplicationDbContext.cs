using DogWalkApp.Infrastructure.Data.Configurations;
using DogWalkApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DogWalkApp.Infrastructure.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new OwnerConfiguration());
		}

		public DbSet<Dog> Dogs { get; set; }

		public DbSet<City> Cities { get; set; }

		public DbSet<WeightRange> WeightRanges { get; set; }

		public DbSet<Owner> Owners { get; set; }

		public DbSet<Walker> Walkers { get; set; }
	}
}
