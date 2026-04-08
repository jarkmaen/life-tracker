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
    AlphaLinolenicAcid DECIMAL(19, 8),
    Carbohydrate DECIMAL(9, 2) NOT NULL,
    Fat DECIMAL(9, 2) NOT NULL,
    Fiber DECIMAL(9, 2) NOT NULL,
    LinoleicAcid DECIMAL(19, 8),
    Protein DECIMAL(9, 2) NOT NULL,
    SaturatedFat DECIMAL(9, 2) NOT NULL,
    Sugar DECIMAL(9, 2) NOT NULL,

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
    FOREIGN KEY (MealId) REFERENCES Meal(Id),
    UNIQUE (IngredientId, MealId)
);

CREATE TABLE Mineral (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Calcium DECIMAL(19, 8),
    Chloride DECIMAL(19, 8) NOT NULL,
    Chromium DECIMAL(19, 8),
    Copper DECIMAL(19, 8),
    Fluoride DECIMAL(19, 8),
    Iodine DECIMAL(19, 8),
    Iron DECIMAL(19, 8),
    Magnesium DECIMAL(19, 8),
    Manganese DECIMAL(19, 8),
    Molybdenum DECIMAL(19, 8),
    Phosphorus DECIMAL(19, 8),
    Potassium DECIMAL(19, 8),
    Selenium DECIMAL(19, 8),
    Sodium DECIMAL(19, 8) NOT NULL,
    Zinc DECIMAL(19, 8),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

CREATE TABLE Vitamin (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Biotin DECIMAL(19, 8),
    Choline DECIMAL(19, 8),
    Folate DECIMAL(19, 8),
    Niacin DECIMAL(19, 8),
    PantothenicAcid DECIMAL(19, 8),
    Riboflavin DECIMAL(19, 8),
    Thiamin DECIMAL(19, 8),
    VitaminA DECIMAL(19, 8),
    VitaminB12 DECIMAL(19, 8),
    VitaminB6 DECIMAL(19, 8),
    VitaminC DECIMAL(19, 8),
    VitaminD DECIMAL(19, 8),
    VitaminE DECIMAL(19, 8),
    VitaminK DECIMAL(19, 8),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);
