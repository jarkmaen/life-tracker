import type {
    Dri,
    Meal,
    MealContribution,
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
        const contributions: MealContribution[] = [];
        const key = nutrient.key as keyof Nutrients;

        for (const meal of selected) {
            const amount = meal.nutrients[key];

            if (amount !== null) {
                contributions.push({
                    id: meal.id,
                    name: meal.name,
                    value: amount
                });
            }
        }

        const hasData = source.some((meal) => meal.nutrients[key] !== null);
        const value = contributions.reduce((sum, item) => sum + item.value, 0);

        return {
            contributions,
            dri: nutrient,
            state: getState(nutrient, hasData, value),
            value
        };
    });
};

export const getScaleMax = ({ recommended, upperLimit }: Dri) => {
    if (recommended === null) {
        return (upperLimit ?? 0) * 1.25;
    }

    if (upperLimit !== null && upperLimit <= recommended * 2.5) {
        return upperLimit * 1.2;
    }

    return recommended * 2;
};

export const getStatusText = ({ dri, state, value }: NutrientTotal) => {
    const target = state === "ok" ? dri.upperLimit : dri.recommended;

    if (state === "none" || !target) {
        return "n/a";
    }

    if (state === "over") {
        return "OVER";
    }

    return `${Math.round((value / target) * 100)}%`;
};
