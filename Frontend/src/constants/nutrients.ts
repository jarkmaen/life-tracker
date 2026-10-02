export const NUTRIENT_COLUMNS = [
    [
        {
            keys: [
                "energy",
                "fat",
                "saturatedFat",
                "carbohydrate",
                "sugar",
                "protein",
                "fiber"
            ],
            label: "MACRONUTRIENTS"
        },
        {
            keys: ["alphaLinolenicAcid", "linoleicAcid"],
            label: "ESSENTIAL FATTY ACIDS"
        },
        {
            keys: [
                "biotin",
                "choline",
                "folate",
                "niacin",
                "pantothenicAcid",
                "riboflavin",
                "thiamin",
                "vitaminA",
                "vitaminB6",
                "vitaminB12",
                "vitaminC",
                "vitaminD",
                "vitaminE",
                "vitaminK"
            ],
            label: "VITAMINS"
        }
    ],
    [
        {
            keys: [
                "calcium",
                "chloride",
                "chromium",
                "copper",
                "fluoride",
                "iodine",
                "iron",
                "magnesium",
                "manganese",
                "molybdenum",
                "phosphorus",
                "potassium",
                "selenium",
                "sodium",
                "zinc"
            ],
            label: "MINERALS"
        }
    ]
];

export const UNIT_SYMBOLS: Record<string, string> = {
    Gram: "g",
    Kilocalorie: "kcal",
    Microgram: "µg",
    Milligram: "mg"
};
