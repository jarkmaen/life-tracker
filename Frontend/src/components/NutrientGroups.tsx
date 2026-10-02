import NutrientGroup from "./NutrientGroup";
import { calculateTotals } from "../utils/nutrients";
import { NUTRIENT_COLUMNS } from "../constants/nutrients";
import { useAppContext } from "../context/useAppContext";

const NutrientGroups = () => {
    const { appState } = useAppContext();
    const { dri, meals, selectedMealIds } = appState;

    const totals = calculateTotals(dri, meals, selectedMealIds);
    const totalsByKey = new Map(totals.map((total) => [total.dri.key, total]));

    return (
        <div className="gap-x-10 grid max-w-390 overflow-x-auto xl:grid-cols-2">
            {NUTRIENT_COLUMNS.map((groups, index) => (
                <div key={index}>
                    {groups.map((group) => (
                        <NutrientGroup
                            key={group.label}
                            label={group.label}
                            totals={group.keys
                                .map((key) => totalsByKey.get(key))
                                .filter((total) => total !== undefined)}
                        />
                    ))}
                </div>
            ))}
        </div>
    );
};

export default NutrientGroups;
