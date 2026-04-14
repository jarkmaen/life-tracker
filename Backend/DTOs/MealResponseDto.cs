using Backend.Models;

namespace Backend.DTOs;

public class MealResponseDto
{
    public int Id { get; set; }
    public int Servings { get; set; }
    public List<MealIngredientResponse> MealIngredients { get; set; } = [];
    public string Name { get; set; } = string.Empty;
}

public class MealIngredientResponse
{
    public decimal QuantityUsed { get; set; }
    public Ingredient Ingredient { get; set; } = null!;
}
