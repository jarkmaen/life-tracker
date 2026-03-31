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

CREATE TABLE Mineral (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL UNIQUE,
    Chloride DECIMAL(18, 9),
    Sodium DECIMAL(18, 9),

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

CREATE TABLE MealIngredient (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IngredientId INT NOT NULL,
    MealId INT NOT NULL,
    QuantityUsed DECIMAL(9, 2) NOT NULL,

    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id),
    FOREIGN KEY (MealId) REFERENCES Meal(Id)
);
