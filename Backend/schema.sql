CREATE TABLE Ingredient (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Energy DECIMAL(9, 2) NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(9, 2) NOT NULL,
    Quantity DECIMAL(9, 2) NOT NULL
);

CREATE TABLE Macro (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    AlphaLinolenicAcid DECIMAL(9, 2),
    Carbohydrate DECIMAL(9, 2),
    Fat DECIMAL(9, 2),
    Fiber DECIMAL(9, 2),
    LinolenicAcid DECIMAL(9, 2),
    Protein DECIMAL(9, 2),
    SaturatedFat DECIMAL(9, 2),
    Sugar DECIMAL(9, 2),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

CREATE TABLE Meal (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name NVARCHAR(255) NOT NULL,
    Servings INT NOT NULL
);

CREATE TABLE MealIngredient (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL,
    MealId INT NOT NULL,
    QuantityUsed DECIMAL(9, 2) NOT NULL,

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id),
    FOREIGN KEY (MealId) REFERENCES Meal(Id)
);

CREATE TABLE Mineral (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Calcium DECIMAL(9, 2),
    Chloride DECIMAL(9, 2),
    Chromium DECIMAL(9, 2),
    Copper DECIMAL(9, 2),
    Fluoride DECIMAL(9, 2),
    Iodine DECIMAL(9, 2),
    Iron DECIMAL(9, 2),
    Magnesium DECIMAL(9, 2),
    Manganese DECIMAL(9, 2),
    Molybdenum DECIMAL(9, 2),
    Phosphorus DECIMAL(9, 2),
    Potassium DECIMAL(9, 2),
    Selenium DECIMAL(9, 2),
    Sodium DECIMAL(9, 2),
    Zinc DECIMAL(9, 2),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

CREATE TABLE Vitamin (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Biotin DECIMAL(9, 2),
    Choline DECIMAL(9, 2),
    Folate DECIMAL(9, 2),
    Niacin DECIMAL(9, 2),
    PantothenicAcid DECIMAL(9, 2),
    Riboflavin DECIMAL(9, 2),
    Thiamin DECIMAL(9, 2),
    VitaminA DECIMAL(9, 2),
    VitaminB12 DECIMAL(9, 2),
    VitaminB6 DECIMAL(9, 2),
    VitaminC DECIMAL(9, 2),
    VitaminD DECIMAL(9, 2),
    VitaminE DECIMAL(9, 2),
    VitaminK DECIMAL(9, 2),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);
