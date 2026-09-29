import { AppContext } from "./AppContext";
import { useContext } from "react";

export const useAppContext = () => {
    const context = useContext(AppContext);

    if (!context) {
        throw new Error("AppProvider missing in component tree");
    }

    return context;
};
