﻿using DogWalkApp.Infrastructure.Data.Models;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<DogOwner> DogOwners { get; set; }

        public DbSet<DogWalker> DogWalkers { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<WeightRange> WeightRanges { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
