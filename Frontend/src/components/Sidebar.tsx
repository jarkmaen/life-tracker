import { MealList } from "./MealList";
import { useAppContext } from "../context/useAppContext";
import { useState } from "react";

export const Sidebar = () => {
    const { appState } = useAppContext();
    const [open, setOpen] = useState(false);

    return (
        <aside className="bg-surface border-b border-black flex flex-col flex-none md:border-b-0 md:border-r md:w-57.5">
            <div className="border-white/10 flex font-extrabold italic items-center justify-between md:border-b p-4 text-[17px] text-white tracking-[-0.04em]">
                NUTRIENT CALCULATOR
                <button
                    className="border border-primary cursor-pointer font-medium md:hidden not-italic px-2 py-0.75 text-[11px] text-primary tracking-[0.04em]"
                    onClick={() => setOpen(true)}
                    type="button"
                >
                    MEALS {appState.selectedMealIds.length}
                </button>
            </div>
            {open && (
                <div
                    className="bg-black/55 fixed inset-0 md:hidden z-10"
                    onClick={() => setOpen(false)}
                />
            )}
            <MealList onClose={() => setOpen(false)} open={open} />
        </aside>
    );
};
