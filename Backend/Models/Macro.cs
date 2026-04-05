namespace Backend.Models;

public class Macro
{
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public decimal AlphaLinolenicAcid { get; set; }
    public decimal Carbohydrate { get; set; }
    public decimal Fat { get; set; }
    public decimal Fiber { get; set; }
    public decimal LinolenicAcid { get; set; }
    public decimal Protein { get; set; }
    public decimal SaturatedFat { get; set; }
    public decimal Sugar { get; set; }
}
