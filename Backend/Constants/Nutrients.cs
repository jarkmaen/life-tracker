using Backend.Enums;

namespace Backend.Constants;

public class Nutrient
{
    public int UsdaId { get; init; }
    public Unit Unit { get; init; }
}

public static class Nutrients
{
    public static readonly Nutrient AlphaLinolenicAcid = new() { UsdaId = 1404, Unit = Unit.Gram };
    public static readonly Nutrient LinoleicAcid = new() { UsdaId = 1316, Unit = Unit.Gram };

    public static readonly Nutrient Calcium = new() { UsdaId = 1087, Unit = Unit.Milligram };
    public static readonly Nutrient Copper = new() { UsdaId = 1098, Unit = Unit.Milligram };
    public static readonly Nutrient Fluoride = new() { UsdaId = 1099, Unit = Unit.Microgram };
    public static readonly Nutrient Iron = new() { UsdaId = 1089, Unit = Unit.Milligram };
    public static readonly Nutrient Magnesium = new() { UsdaId = 1090, Unit = Unit.Milligram };
    public static readonly Nutrient Manganese = new() { UsdaId = 1101, Unit = Unit.Milligram };
    public static readonly Nutrient Phosphorus = new() { UsdaId = 1091, Unit = Unit.Milligram };
    public static readonly Nutrient Potassium = new() { UsdaId = 1092, Unit = Unit.Milligram };
    public static readonly Nutrient Selenium = new() { UsdaId = 1103, Unit = Unit.Microgram };
    public static readonly Nutrient Zinc = new() { UsdaId = 1095, Unit = Unit.Milligram };

    public static readonly Nutrient Choline = new() { UsdaId = 1180, Unit = Unit.Milligram };
    public static readonly Nutrient Folate = new() { UsdaId = 1190, Unit = Unit.Microgram };
    public static readonly Nutrient Niacin = new() { UsdaId = 1167, Unit = Unit.Milligram };
    public static readonly Nutrient PantothenicAcid = new() { UsdaId = 1170, Unit = Unit.Milligram };
    public static readonly Nutrient Riboflavin = new() { UsdaId = 1166, Unit = Unit.Milligram };
    public static readonly Nutrient Thiamin = new() { UsdaId = 1165, Unit = Unit.Milligram };
    public static readonly Nutrient VitaminA = new() { UsdaId = 1106, Unit = Unit.Microgram };
    public static readonly Nutrient VitaminB12 = new() { UsdaId = 1178, Unit = Unit.Microgram };
    public static readonly Nutrient VitaminB6 = new() { UsdaId = 1175, Unit = Unit.Milligram };
    public static readonly Nutrient VitaminC = new() { UsdaId = 1162, Unit = Unit.Milligram };
    public static readonly Nutrient VitaminD = new() { UsdaId = 1114, Unit = Unit.Microgram };
    public static readonly Nutrient VitaminE = new() { UsdaId = 1109, Unit = Unit.Milligram };
    public static readonly Nutrient VitaminK1 = new() { UsdaId = 1185, Unit = Unit.Microgram };
    public static readonly Nutrient VitaminK1Dihydro = new() { UsdaId = 1184, Unit = Unit.Microgram };
    public static readonly Nutrient VitaminK2 = new() { UsdaId = 1183, Unit = Unit.Microgram };
}
