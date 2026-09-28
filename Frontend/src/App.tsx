import { useAppContext } from "./context/AppContext";
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

                setAppState({
                    dri: driData,
                    meals: mealsData
                });
            } catch (e) {
                console.error(e);
            }
        };

        fetchData();
    }, [setAppState]);

    return <div className="font-mono h-screen text-[11px]"></div>;
};

export default App;
