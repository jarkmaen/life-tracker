CREATE TABLE [Ingredients] (
    [Id] int NOT NULL IDENTITY,
    [Energy] decimal(19,8) NOT NULL,
    [Name] nvarchar(255) NOT NULL,
    [Price] decimal(19,8) NOT NULL,
    [Quantity] decimal(19,8) NOT NULL,
    [UsdaId] int NULL,
    CONSTRAINT [PK_Ingredients] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Meals] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(255) NOT NULL,
    [Servings] int NOT NULL,
    CONSTRAINT [PK_Meals] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Macros] (
    [Id] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [Carbohydrate] decimal(19,8) NOT NULL,
    [Fat] decimal(19,8) NOT NULL,
    [Fiber] decimal(19,8) NOT NULL,
    [Protein] decimal(19,8) NOT NULL,
    [SaturatedFat] decimal(19,8) NOT NULL,
    [Sugar] decimal(19,8) NOT NULL,
    [AlphaLinolenicAcid] decimal(19,8) NULL,
    [LinoleicAcid] decimal(19,8) NULL,
    CONSTRAINT [PK_Macros] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Macros_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [Minerals] (
    [Id] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [Chloride] decimal(19,8) NOT NULL,
    [Sodium] decimal(19,8) NOT NULL,
    [Calcium] decimal(19,8) NULL,
    [Chromium] decimal(19,8) NULL,
    [Copper] decimal(19,8) NULL,
    [Fluoride] decimal(19,8) NULL,
    [Iodine] decimal(19,8) NULL,
    [Iron] decimal(19,8) NULL,
    [Magnesium] decimal(19,8) NULL,
    [Manganese] decimal(19,8) NULL,
    [Molybdenum] decimal(19,8) NULL,
    [Phosphorus] decimal(19,8) NULL,
    [Potassium] decimal(19,8) NULL,
    [Selenium] decimal(19,8) NULL,
    [Zinc] decimal(19,8) NULL,
    CONSTRAINT [PK_Minerals] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Minerals_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [Vitamins] (
    [Id] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [Biotin] decimal(19,8) NULL,
    [Choline] decimal(19,8) NULL,
    [Folate] decimal(19,8) NULL,
    [Niacin] decimal(19,8) NULL,
    [PantothenicAcid] decimal(19,8) NULL,
    [Riboflavin] decimal(19,8) NULL,
    [Thiamin] decimal(19,8) NULL,
    [VitaminA] decimal(19,8) NULL,
    [VitaminB12] decimal(19,8) NULL,
    [VitaminB6] decimal(19,8) NULL,
    [VitaminC] decimal(19,8) NULL,
    [VitaminD] decimal(19,8) NULL,
    [VitaminE] decimal(19,8) NULL,
    [VitaminK] decimal(19,8) NULL,
    CONSTRAINT [PK_Vitamins] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Vitamins_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [MealIngredients] (
    [Id] int NOT NULL IDENTITY,
    [IngredientId] int NOT NULL,
    [MealId] int NOT NULL,
    [QuantityUsed] decimal(19,8) NOT NULL,
    CONSTRAINT [PK_MealIngredients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MealIngredients_Ingredients_IngredientId] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredients] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MealIngredients_Meals_MealId] FOREIGN KEY ([MealId]) REFERENCES [Meals] ([Id]) ON DELETE CASCADE
);
GO


CREATE UNIQUE INDEX [IX_Macros_IngredientId] ON [Macros] ([IngredientId]);
GO


CREATE UNIQUE INDEX [IX_MealIngredients_IngredientId_MealId] ON [MealIngredients] ([IngredientId], [MealId]);
GO


CREATE INDEX [IX_MealIngredients_MealId] ON [MealIngredients] ([MealId]);
GO


CREATE UNIQUE INDEX [IX_Minerals_IngredientId] ON [Minerals] ([IngredientId]);
GO


CREATE UNIQUE INDEX [IX_Vitamins_IngredientId] ON [Vitamins] ([IngredientId]);
GO


