namespace Backend.Models;

public class MealIngredient
{
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public int MealId { get; set; }
    public decimal QuantityUsed { get; set; }

    public Ingredient Ingredient { get; set; } = null!;
}
