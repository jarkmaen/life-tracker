import type {
    Dri,
    Meal,
    Nutrients,
    NutrientState,
    NutrientTotal
} from "../types";

const getState = (dri: Dri, hasData: boolean, value: number): NutrientState => {
    if (!hasData) {
        return "none";
    }

    if (dri.upperLimit !== null && value > dri.upperLimit) {
        return "over";
    }

    if (dri.recommended !== null) {
        return value >= dri.recommended ? "met" : "low";
    }

    return "ok";
};

export const calculateTotals = (
    dri: Dri[],
    meals: Meal[],
    selectedMealIds: number[]
): NutrientTotal[] => {
    const selected = meals.filter((meal) => selectedMealIds.includes(meal.id));
    const source = selected.length > 0 ? selected : meals;

    return dri.map((nutrient) => {
        const key = nutrient.key as keyof Nutrients;

        const hasData = source.some((meal) => meal.nutrients[key] !== null);
        const value = selected.reduce(
            (sum, meal) => sum + (meal.nutrients[key] ?? 0),
            0
        );

        return {
            dri: nutrient,
            state: getState(nutrient, hasData, value),
            value
        };
    });
};
