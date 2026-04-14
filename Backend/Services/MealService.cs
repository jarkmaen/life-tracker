using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services;

public class MealService(AppDbContext context) : IMealService
{
    public async Task<List<Meal>> GetAllAsync()
    {
        return await context.Meals
            .Include(m => m.MealIngredients)
            .ToListAsync();
    }

    public async Task<Meal> AddAsync(MealCreateDto dto)
    {
        var meal = new Meal
        {
            Name = dto.Name,
            Servings = dto.Servings,
            MealIngredients = [.. dto.MealIngredients.Select(i => new MealIngredient
            {
                IngredientId = i.IngredientId,
                QuantityUsed = i.QuantityUsed
            })]
        };

        context.Meals.Add(meal);
        await context.SaveChangesAsync();

        return meal;
    }

    public async Task<Meal?> GetByIdAsync(int id)
    {
        return await context.Meals
            .Include(m => m.MealIngredients)
                .ThenInclude(mI => mI.Ingredient)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}
