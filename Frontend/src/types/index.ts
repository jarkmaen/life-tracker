import type { components } from "./api";

export interface NutrientTotal {
    dri: Dri;
    state: NutrientState;
    value: number;
}

export type Dri = components["schemas"]["DriResponseDto"];
export type Meal = components["schemas"]["MealResponseDto"];
export type Nutrients = components["schemas"]["NutrientDto"];

export type NutrientState = "low" | "met" | "none" | "ok" | "over";
