using Backend.Data;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services;

public class IngredientService(AppDbContext context) : IIngredientService
{
    public async Task<Ingredient> AddAsync(Ingredient ingredient)
    {
        context.Ingredients.Add(ingredient);
        await context.SaveChangesAsync();

        return ingredient;
    }

    public async Task<Ingredient?> GetByIdAsync(int id)
    {
        return await context.Ingredients.FindAsync(id);
    }

    public async Task<List<Ingredient>> GetAllAsync()
    {
        return await context.Ingredients.ToListAsync();
    }
}
