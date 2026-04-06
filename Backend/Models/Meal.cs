using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Meal
{
    public int Id { get; set; }

    [MaxLength(255)]
    [Required]
    public string Name { get; set; } = string.Empty;

    public int Servings { get; set; }

    public List<MealIngredient> MealIngredients { get; set; } = [];
}
