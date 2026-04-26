import App from "./App.tsx";
import ReactDOM from "react-dom/client";
import { AppProvider } from "./context/AppContext.tsx";
import { BrowserRouter as Router } from "react-router-dom";

ReactDOM.createRoot(document.getElementById("root")!).render(
    <Router>
        <AppProvider>
            <App />
        </AppProvider>
    </Router>
);
