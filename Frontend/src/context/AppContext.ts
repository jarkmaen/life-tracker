import type { Dri, Meal } from "../types";
import { createContext } from "react";

export interface AppContextType {
    appState: AppState;
    setAppState: React.Dispatch<React.SetStateAction<AppState>>;
}

export interface AppState {
    dri: Dri[];
    meals: Meal[];
}

export const AppContext = createContext<AppContextType | null>(null);
