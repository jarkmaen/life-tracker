import { MealItem } from "./MealItem";
import { useAppContext } from "../context/useAppContext";

export const MealList = () => {
    const { appState, setAppState } = useAppContext();
    const { meals, selectedMealIds } = appState;

    const clear = () => {
        setAppState((prev) => ({ ...prev, selectedMealIds: [] }));
    };

    const toggle = (id: number) => {
        setAppState((prev) => ({
            ...prev,
            selectedMealIds: prev.selectedMealIds.includes(id)
                ? prev.selectedMealIds.filter((x) => x !== id)
                : [...prev.selectedMealIds, id]
        }));
    };

    return (
        <div className="flex-1 min-h-0 overflow-y-auto py-3">
            <div className="flex justify-between pb-3 px-4 text-[11px] text-foreground-subtle">
                <span>MEALS</span>
                <button
                    className="cursor-pointer hover:text-white text-foreground-muted"
                    onClick={clear}
                    type="button"
                >
                    clear
                </button>
            </div>
            {meals.length === 0 ? (
                <p className="px-4 text-foreground-subtle">no meals found</p>
            ) : (
                meals.map((meal) => {
                    const { id } = meal;

                    return (
                        <MealItem
                            checked={selectedMealIds.includes(id)}
                            key={id}
                            meal={meal}
                            onToggle={() => toggle(id)}
                        />
                    );
                })
            )}
        </div>
    );
};
