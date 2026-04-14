using Backend.DTOs;
using Backend.Models;

namespace Backend.Services;

public interface IMealService
{
    Task<List<Meal>> GetAllAsync();
    Task<Meal> AddAsync(MealCreateDto dto);
    Task<Meal?> GetByIdAsync(int id);
}
