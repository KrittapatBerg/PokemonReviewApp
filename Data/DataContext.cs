using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                        .HasKey(a => new { a.PokemonId, a.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                        .HasOne(a => a.Category)
                        .WithMany(a => a.PokemonCategories)
                        .HasForeignKey(a => a.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                        .HasOne(a => a.Category)
                        .WithMany(a => a.PokemonCategories)
                        .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                        .HasKey(a => new { a.PokemonId, a.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                        .HasOne(a => a.Pokemon)
                        .WithMany(a => a.PokemonOwners)
                        .HasForeignKey(a => a.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                        .HasOne(a => a.Owner)
                        .WithMany(a => a.PokemonOwners)
                        .HasForeignKey(a => a.OwnerId);

            modelBuilder.Entity<Reviewer>()
                .HasKey(r => r.ReviwerId); // Define the primary key

            base.OnModelCreating(modelBuilder);
        }

    }

}

