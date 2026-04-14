using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services;

public class MealService(AppDbContext context) : IMealService
{
    public async Task<List<MealResponseDto>> GetAllAsync()
    {
        var meals = await context.Meals
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Macro)
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Mineral)
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Vitamin)
            .ToListAsync();

        return [.. meals.Select(m => new MealResponseDto
        {
            Id = m.Id,
            Servings = m.Servings,
            MealIngredients = [.. m.MealIngredients.Select(mI => new MealIngredientResponse
            {
                QuantityUsed = mI.QuantityUsed,
                Ingredient = mI.Ingredient
            })],
            Name = m.Name
        })];
    }

    public async Task<MealResponseDto> AddAsync(MealCreateDto dto)
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

        return (await GetByIdAsync(meal.Id))!;
    }

    public async Task<MealResponseDto?> GetByIdAsync(int id)
    {
        var meal = await context.Meals
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Macro)
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Mineral)
            .Include(m => m.MealIngredients).ThenInclude(mI => mI.Ingredient).ThenInclude(i => i.Vitamin)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (meal == null)
        {
            return null;
        }

        return new MealResponseDto
        {
            Id = meal.Id,
            Servings = meal.Servings,
            MealIngredients = [.. meal.MealIngredients.Select(mI => new MealIngredientResponse
            {
                QuantityUsed = mI.QuantityUsed,
                Ingredient = mI.Ingredient
            })],
            Name = meal.Name
        };
    }
}
