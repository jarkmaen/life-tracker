namespace CLI.DTOs;

public class IngredientCreateDto
{
    public decimal Carbohydrate { get; set; }
    public decimal Energy { get; set; }
    public decimal Fat { get; set; }
    public decimal Fiber { get; set; }
    public decimal Price { get; set; }
    public decimal Protein { get; set; }
    public decimal Quantity { get; set; }
    public decimal Salt { get; set; }
    public decimal SaturatedFat { get; set; }
    public decimal Sugar { get; set; }
    public int? UsdaId { get; set; }
    public string Name { get; set; } = string.Empty;
}
