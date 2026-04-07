namespace Backend.DTOs;

public class FoodNutrient
{
    public decimal Amount { get; set; }
    public Nutrient Nutrient { get; set; } = null!;
}

public class Nutrient
{
    public int Id { get; set; }
    public string UnitName { get; set; } = string.Empty;
}

public class UsdaResponseDto
{
    public List<FoodNutrient> FoodNutrients { get; set; } = [];
}
