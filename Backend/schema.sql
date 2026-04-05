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
    AlphaLinolenicAcid DECIMAL(9, 2) NOT NULL,
    Carbohydrate DECIMAL(9, 2) NOT NULL,
    Fat DECIMAL(9, 2) NOT NULL,
    Fiber DECIMAL(9, 2) NOT NULL,
    LinolenicAcid DECIMAL(9, 2) NOT NULL,
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
    Calcium DECIMAL(9, 2) NOT NULL,
    Chloride DECIMAL(9, 2) NOT NULL,
    Chromium DECIMAL(9, 2) NOT NULL,
    Copper DECIMAL(9, 2) NOT NULL,
    Fluoride DECIMAL(9, 2) NOT NULL,
    Iodine DECIMAL(9, 2) NOT NULL,
    Iron DECIMAL(9, 2) NOT NULL,
    Magnesium DECIMAL(9, 2) NOT NULL,
    Manganese DECIMAL(9, 2) NOT NULL,
    Molybdenum DECIMAL(9, 2) NOT NULL,
    Phosphorus DECIMAL(9, 2) NOT NULL,
    Potassium DECIMAL(9, 2) NOT NULL,
    Selenium DECIMAL(9, 2) NOT NULL,
    Sodium DECIMAL(9, 2) NOT NULL,
    Zinc DECIMAL(9, 2) NOT NULL,

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

CREATE TABLE Vitamin (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Biotin DECIMAL(9, 2) NOT NULL,
    Choline DECIMAL(9, 2) NOT NULL,
    Folate DECIMAL(9, 2) NOT NULL,
    Niacin DECIMAL(9, 2) NOT NULL,
    PantothenicAcid DECIMAL(9, 2) NOT NULL,
    Riboflavin DECIMAL(9, 2) NOT NULL,
    Thiamin DECIMAL(9, 2) NOT NULL,
    VitaminA DECIMAL(9, 2) NOT NULL,
    VitaminB12 DECIMAL(9, 2) NOT NULL,
    VitaminB6 DECIMAL(9, 2) NOT NULL,
    VitaminC DECIMAL(9, 2) NOT NULL,
    VitaminD DECIMAL(9, 2) NOT NULL,
    VitaminE DECIMAL(9, 2) NOT NULL,
    VitaminK DECIMAL(9, 2) NOT NULL,

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);
