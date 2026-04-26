import { Route, Routes } from "react-router-dom";
import { useAppContext } from "./context/AppContext";
import { useEffect } from "react";

const App = () => {
    const { setAppState } = useAppContext();

    useEffect(() => {
        const fetchData = async () => {
            try {
                const [driRes, mealsRes] = await Promise.all([
                    fetch("https://localhost:7203/api/dri"),
                    fetch("https://localhost:7203/api/meals")
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

    return (
        <Routes>
            <Route path="/exercises" />
            <Route path="/habits" />
            <Route path="/nutrients" />
        </Routes>
    );
};

export default App;
