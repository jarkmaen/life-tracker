namespace Backend.Models;

public class Mineral
{
    public int Id { get; set; }
    public int IngredientId { get; set; }
    public decimal Chloride { get; set; }
    public decimal Sodium { get; set; }
    public decimal? Calcium { get; set; }
    public decimal? Chromium { get; set; }
    public decimal? Copper { get; set; }
    public decimal? Fluoride { get; set; }
    public decimal? Iodine { get; set; }
    public decimal? Iron { get; set; }
    public decimal? Magnesium { get; set; }
    public decimal? Manganese { get; set; }
    public decimal? Molybdenum { get; set; }
    public decimal? Phosphorus { get; set; }
    public decimal? Potassium { get; set; }
    public decimal? Selenium { get; set; }
    public decimal? Zinc { get; set; }
}
