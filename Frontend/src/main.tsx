import ReactDOM from "react-dom/client";
import { App } from "./App.tsx";
import { AppProvider } from "./context/AppProvider.tsx";

ReactDOM.createRoot(document.getElementById("root")!).render(
    <AppProvider>
        <App />
    </AppProvider>
);
