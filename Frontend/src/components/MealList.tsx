import { MealItem } from "./MealItem";
import { useAppContext } from "../context/useAppContext";

type Props = {
    onClose: () => void;
    open: boolean;
};

export const MealList = ({ onClose, open }: Props) => {
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
        <div
            className={`bg-surface border-primary border-t-2 bottom-0 fixed flex-1 inset-x-0 max-h-[70vh] md:block md:border-t-0 md:max-h-none md:static min-h-0 overflow-y-auto z-20 ${open ? "block" : "hidden"}`}
        >
            <div className="bg-surface flex justify-between px-4 py-3 sticky text-[11px] text-foreground-subtle top-0">
                <span>MEALS</span>
                <div className="flex gap-3.5">
                    <button
                        className="cursor-pointer hover:text-white text-foreground-muted"
                        onClick={clear}
                        type="button"
                    >
                        clear
                    </button>
                    <button
                        className="cursor-pointer md:hidden text-primary"
                        onClick={onClose}
                        type="button"
                    >
                        done
                    </button>
                </div>
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
