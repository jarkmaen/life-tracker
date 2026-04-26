import type { Dri, Meal } from "../types";
import { createContext, type ReactNode, useContext, useState } from "react";

interface AppContextType {
    appState: AppState;
    setAppState: React.Dispatch<React.SetStateAction<AppState>>;
}

interface AppState {
    dri: Dri[];
    meals: Meal[];
}

const AppContext = createContext<AppContextType | null>(null);

export const AppProvider = ({ children }: { children: ReactNode }) => {
    const [appState, setAppState] = useState<AppState>({
        dri: [],
        meals: []
    });

    return (
        <AppContext.Provider value={{ appState, setAppState }}>
            {children}
        </AppContext.Provider>
    );
};

export const useAppContext = () => {
    const context = useContext(AppContext);

    if (!context) {
        throw new Error("AppProvider missing in component tree");
    }

    return context;
};
