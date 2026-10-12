namespace CLI.DTOs;

public class IngredientResponseDto
{
    public decimal Energy { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
