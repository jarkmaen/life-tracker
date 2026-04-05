using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Meal
{
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;

    public int Servings { get; set; }

    public List<MealIngredient> MealIngredients { get; set; } = [];
}
