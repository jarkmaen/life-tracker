using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Ingredient> Ingredients { get; set; } = null!;
    public DbSet<Macro> Macros { get; set; } = null!;
    public DbSet<Meal> Meals { get; set; } = null!;
    public DbSet<MealIngredient> MealIngredients { get; set; } = null!;
    public DbSet<Mineral> Minerals { get; set; } = null!;
    public DbSet<Vitamin> Vitamins { get; set; } = null!;

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>().HavePrecision(9, 2);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Macro>().HasIndex(m => m.IngredientId).IsUnique();
        modelBuilder.Entity<Mineral>().HasIndex(m => m.IngredientId).IsUnique();
        modelBuilder.Entity<Vitamin>().HasIndex(v => v.IngredientId).IsUnique();

        modelBuilder.Entity<MealIngredient>()
            .HasOne(m => m.Ingredient)
            .WithMany()
            .HasForeignKey(m => m.IngredientId);

        modelBuilder.Entity<MealIngredient>()
            .HasOne(m => m.Meal)
            .WithMany(m => m.MealIngredients)
            .HasForeignKey(m => m.MealId);
    }
}
