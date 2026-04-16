using Backend.Enums;

namespace Backend.Constants;

public class Nutrient
{
    public decimal? Recommended { get; init; }
    public decimal? UpperLimit { get; init; }
    public int? UsdaId { get; init; }
    public string Name { get; init; } = string.Empty;
    public Unit Unit { get; init; }
}

public static class Nutrients
{
    public static readonly Nutrient Carbohydrate = new() { Recommended = 352, Name = "Carbohydrate", Unit = Unit.Gram };
    public static readonly Nutrient Energy = new() { Recommended = 2558, Name = "Energy", Unit = Unit.Kilocalorie };
    public static readonly Nutrient Fat = new() { Recommended = 78, Name = "Fat", Unit = Unit.Gram };
    public static readonly Nutrient Fiber = new() { Recommended = 36, Name = "Fiber", Unit = Unit.Gram };
    public static readonly Nutrient Protein = new() { Recommended = 104, Name = "Protein", Unit = Unit.Gram };
    public static readonly Nutrient SaturatedFat = new() { UpperLimit = 28, Name = "Saturated Fat", Unit = Unit.Gram };
    public static readonly Nutrient Sugar = new() { UpperLimit = 64, Name = "Sugar", Unit = Unit.Gram };

    public static readonly Nutrient AlphaLinolenicAcid = new() { Recommended = 1.6m, UsdaId = 1404, Name = "Alpha Linolenic Acid", Unit = Unit.Gram };
    public static readonly Nutrient LinoleicAcid = new() { Recommended = 17, UsdaId = 1316, Name = "Linoleic Acid", Unit = Unit.Gram };

    public static readonly Nutrient Chloride = new() { Recommended = 2300, UpperLimit = 3600, Name = "Chloride", Unit = Unit.Milligram };
    public static readonly Nutrient Sodium = new() { Recommended = 1500, UpperLimit = 2300, Name = "Sodium", Unit = Unit.Milligram };

    public static readonly Nutrient Calcium = new() { Recommended = 1000, UpperLimit = 2500, UsdaId = 1087, Name = "Calcium", Unit = Unit.Milligram };
    public static readonly Nutrient Chromium = new() { Recommended = 35, Name = "Chromium", Unit = Unit.Microgram };
    public static readonly Nutrient Copper = new() { Recommended = 0.9m, UpperLimit = 10, UsdaId = 1098, Name = "Copper", Unit = Unit.Milligram };
    public static readonly Nutrient Fluoride = new() { Recommended = 4000, UpperLimit = 10000, UsdaId = 1099, Name = "Fluoride", Unit = Unit.Microgram };
    public static readonly Nutrient Iodine = new() { Recommended = 150, UpperLimit = 1100, Name = "Iodine", Unit = Unit.Microgram };
    public static readonly Nutrient Iron = new() { Recommended = 8, UpperLimit = 45, UsdaId = 1089, Name = "Iron", Unit = Unit.Milligram };
    public static readonly Nutrient Magnesium = new() { Recommended = 400, UsdaId = 1090, Name = "Magnesium", Unit = Unit.Milligram };
    public static readonly Nutrient Manganese = new() { Recommended = 2.3m, UpperLimit = 11, UsdaId = 1101, Name = "Manganese", Unit = Unit.Milligram };
    public static readonly Nutrient Molybdenum = new() { Recommended = 45, UpperLimit = 2000, Name = "Molybdenum", Unit = Unit.Microgram };
    public static readonly Nutrient Phosphorus = new() { Recommended = 700, UpperLimit = 4000, UsdaId = 1091, Name = "Phosphorus", Unit = Unit.Milligram };
    public static readonly Nutrient Potassium = new() { Recommended = 3400, UsdaId = 1092, Name = "Potassium", Unit = Unit.Milligram };
    public static readonly Nutrient Selenium = new() { Recommended = 55, UpperLimit = 400, UsdaId = 1103, Name = "Selenium", Unit = Unit.Microgram };
    public static readonly Nutrient Zinc = new() { Recommended = 11, UpperLimit = 40, UsdaId = 1095, Name = "Zinc", Unit = Unit.Milligram };

    public static readonly Nutrient Biotin = new() { Recommended = 30, Name = "Biotin", Unit = Unit.Microgram };
    public static readonly Nutrient Choline = new() { Recommended = 550, UpperLimit = 3500, UsdaId = 1180, Name = "Choline", Unit = Unit.Milligram };
    public static readonly Nutrient Folate = new() { Recommended = 400, UpperLimit = 1000, UsdaId = 1190, Name = "Folate", Unit = Unit.Microgram };
    public static readonly Nutrient Niacin = new() { Recommended = 16, UpperLimit = 35, UsdaId = 1167, Name = "Niacin", Unit = Unit.Milligram };
    public static readonly Nutrient PantothenicAcid = new() { Recommended = 5, UsdaId = 1170, Name = "Pantothenic Acid", Unit = Unit.Milligram };
    public static readonly Nutrient Riboflavin = new() { Recommended = 1.3m, UsdaId = 1166, Name = "Riboflavin", Unit = Unit.Milligram };
    public static readonly Nutrient Thiamin = new() { Recommended = 1.2m, UsdaId = 1165, Name = "Thiamin", Unit = Unit.Milligram };
    public static readonly Nutrient VitaminA = new() { Recommended = 900, UpperLimit = 3000, UsdaId = 1106, Name = "Vitamin A", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminB12 = new() { Recommended = 2.4m, UsdaId = 1178, Name = "Vitamin B12", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminB6 = new() { Recommended = 1.3m, UpperLimit = 100, UsdaId = 1175, Name = "Vitamin B6", Unit = Unit.Milligram };
    public static readonly Nutrient VitaminC = new() { Recommended = 90, UpperLimit = 2000, UsdaId = 1162, Name = "Vitamin C", Unit = Unit.Milligram };
    public static readonly Nutrient VitaminD = new() { Recommended = 15, UpperLimit = 100, UsdaId = 1114, Name = "Vitamin D", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminE = new() { Recommended = 15, UpperLimit = 1000, UsdaId = 1109, Name = "Vitamin E", Unit = Unit.Milligram };
    public static readonly Nutrient VitaminK = new() { Recommended = 120, Name = "Vitamin K", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminK1 = new() { UsdaId = 1185, Name = "Vitamin K1", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminK1Dihydro = new() { UsdaId = 1184, Name = "Vitamin K1 Dihydro", Unit = Unit.Microgram };
    public static readonly Nutrient VitaminK2 = new() { UsdaId = 1183, Name = "Vitamin K2", Unit = Unit.Microgram };
}