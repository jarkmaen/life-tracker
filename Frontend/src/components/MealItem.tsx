import type { Meal } from "../types";
import { formatNumber } from "../utils/format";

type Props = {
    checked: boolean;
    meal: Meal;
    onToggle: () => void;
};

const MealItem = ({ checked, meal, onToggle }: Props) => {
    const energy = Number(meal.nutrients?.energy ?? 0);
    const protein = Number(meal.nutrients?.protein ?? 0);

    return (
        <label
            className={`border-r-2 cursor-pointer grid grid-cols-[26px_1fr] has-focus-visible:-outline-offset-1 has-focus-visible:outline has-focus-visible:outline-primary hover:text-white px-4 py-1.75 ${
                checked
                    ? "bg-white/5 border-primary text-white"
                    : "border-transparent text-foreground-muted"
            }`}
        >
            <input
                checked={checked}
                className="sr-only"
                onChange={onToggle}
                type="checkbox"
            />
            <span className={checked ? "text-primary" : undefined}>
                {checked ? "[x]" : "[ ]"}
            </span>
            <span>
                {meal.name}
                <small className="block text-[11px] text-foreground-subtle">
                    {formatNumber(energy)} kcal &middot; {formatNumber(protein)} g prot
                </small>
            </span>
        </label>
    );
};

export default MealItem;
