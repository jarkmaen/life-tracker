import Sidebar from "./components/Sidebar";
import { Route, Routes } from "react-router-dom";
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

    return (
        <div className="flex font-mono h-screen text-[11px]">
            <Sidebar />
            <Routes>
                <Route path="/" />
                <Route path="/exercises" />
                <Route path="/habits" />
                <Route path="/nutrients" />
            </Routes>
        </div>
    );
};

export default App;
