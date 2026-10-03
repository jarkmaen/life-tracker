import NutrientGroups from "./components/NutrientGroups";
import Sidebar from "./components/Sidebar";
import { StatusBar } from "./components/StatusBar";
import { useAppContext } from "./context/useAppContext";
import { useEffect } from "react";

const App = () => {
    const { setAppState } = useAppContext();

    useEffect(() => {
        const fetchData = async () => {
            try {
                const [driRes, mealsRes] = await Promise.all([
                    fetch("/api/dri"),
                    fetch("/api/meals")
                ]);

                const driData = await driRes.json();
                const mealsData = await mealsRes.json();

                setAppState((prev) => ({
                    ...prev,
                    dri: driData,
                    meals: mealsData
                }));
            } catch (e) {
                console.error(e);
            }
        };

        fetchData();
    }, [setAppState]);

    return (
        <div className="flex flex-col h-full md:flex-row">
            <Sidebar />
            <main className="flex flex-1 flex-col min-h-0 min-w-0">
                <div className="flex-1 min-h-0 overflow-y-auto px-5 py-4">
                    <NutrientGroups />
                </div>
                <StatusBar />
            </main>
        </div>
    );
};

export default App;
