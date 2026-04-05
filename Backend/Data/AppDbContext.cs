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
        modelBuilder.Entity<MealIngredient>().HasIndex(mI => new { mI.IngredientId, mI.MealId }).IsUnique();
        modelBuilder.Entity<Mineral>().HasIndex(m => m.IngredientId).IsUnique();
        modelBuilder.Entity<Vitamin>().HasIndex(v => v.IngredientId).IsUnique();

        modelBuilder.Entity<MealIngredient>()
            .HasOne(mI => mI.Ingredient)
            .WithMany()
            .HasForeignKey(mI => mI.IngredientId);

        modelBuilder.Entity<MealIngredient>()
            .HasOne(mI => mI.Meal)
            .WithMany(m => m.MealIngredients)
            .HasForeignKey(mI => mI.MealId);
    }
}
