namespace Backend.Models;

public class Ingredient
{
    public int Id { get; set; }
    public decimal Energy { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    public Macro Macro { get; set; } = null!;
    public Mineral Mineral { get; set; } = null!;
    public Vitamin Vitamin { get; set; } = null!;
}
