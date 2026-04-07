using Backend.DTOs;
using Backend.Models;

namespace Backend.Services;

public interface IIngredientService
{
    Task<Ingredient> AddAsync(IngredientCreateDto dto);
    Task<Ingredient?> GetByIdAsync(int id);
    Task<List<Ingredient>> GetAllAsync();
}
