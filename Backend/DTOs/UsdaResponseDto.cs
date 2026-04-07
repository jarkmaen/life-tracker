namespace Backend.DTOs;

public class UsdaFoodNutrient
{
    public decimal Amount { get; set; }
    public UsdaNutrient Nutrient { get; set; } = null!;
}

public class UsdaNutrient
{
    public int Id { get; set; }
    public string UnitName { get; set; } = string.Empty;
}

public class UsdaResponseDto
{
    public List<UsdaFoodNutrient> FoodNutrients { get; set; } = [];
}
