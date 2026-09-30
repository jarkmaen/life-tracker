using Backend.Models;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs;

public class MealResponseDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int Servings { get; set; }

    [Required]
    public List<MealIngredientResponse> MealIngredients { get; set; } = [];

    [Required]
    public NutrientDto Nutrients { get; set; } = new();

    [Required]
    public string Name { get; set; } = string.Empty;
}

public class MealIngredientResponse
{
    [Required]
    public decimal QuantityUsed { get; set; }

    [Required]
    public Ingredient Ingredient { get; set; } = null!;
}
