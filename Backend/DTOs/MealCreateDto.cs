using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs;

public class MealCreateDto
{
    [Range(1, int.MaxValue)]
    public int Servings { get; set; }

    public List<MealIngredientCreate> MealIngredients { get; set; } = [];

    [MaxLength(255)]
    [Required]
    public string Name { get; set; } = string.Empty;
}

public class MealIngredientCreate
{
    [Range(0, 9999999.99)]
    public decimal QuantityUsed { get; set; }

    [Range(1, int.MaxValue)]
    public int IngredientId { get; set; }
}
