import type { NutrientState, NutrientTotal } from "../types";
import { getScaleMax } from "../utils/nutrients";

const FILL_COLORS: Record<NutrientState, string> = {
    low: "bg-primary",
    met: "bg-success",
    none: "",
    ok: "bg-foreground-muted",
    over: "bg-danger"
};

export const NutrientBar = ({ total }: { total: NutrientTotal }) => {
    const { dri, state, value } = total;
    const max = getScaleMax(dri);

    const toPercent = (amount: number) => `${Math.min(amount / max, 1) * 100}%`;

    return (
        <div
            aria-hidden="true"
            className={`h-2.25 relative ${state === "none" ? "bar-blank" : "bg-muted"}`}
        >
            {state !== "none" && (
                <div
                    className={`absolute bar-fill duration-300 inset-y-0 left-0 transition-[width] ${FILL_COLORS[state]}`}
                    style={{ width: toPercent(value) }}
                />
            )}
            {dri.recommended !== null && (
                <div
                    className="-bottom-0.75 -ml-px -top-0.75 absolute bg-white w-0.5 z-10"
                    style={{ left: toPercent(dri.recommended) }}
                />
            )}
            {dri.upperLimit !== null && dri.upperLimit <= max && (
                <div
                    className="-bottom-0.75 -ml-px -top-0.75 absolute bar-limit w-0.5 z-10"
                    style={{ left: toPercent(dri.upperLimit) }}
                />
            )}
        </div>
    );
};
