using Backend.Models;

namespace Backend.Services;

public interface IIngredientService
{
    Task<Ingredient> AddAsync(Ingredient ingredient);
    Task<Ingredient?> GetByIdAsync(int id);
    Task<List<Ingredient>> GetAllAsync();
}
