import { AppContext, type AppState } from "./AppContext";
import { type ReactNode, useState } from "react";

export const AppProvider = ({ children }: { children: ReactNode }) => {
    const [appState, setAppState] = useState<AppState>({
        dri: [],
        meals: [],
        selectedMealIds: []
    });

    return (
        <AppContext.Provider value={{ appState, setAppState }}>
            {children}
        </AppContext.Provider>
    );
};
