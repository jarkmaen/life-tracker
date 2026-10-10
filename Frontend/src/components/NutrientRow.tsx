import type { NutrientState, NutrientTotal } from "../types";
import { formatNumber } from "../utils/format";
import { getStatusText } from "../utils/nutrients";
import { NutrientBar } from "./NutrientBar";
import { NutrientTooltip } from "./NutrientTooltip";
import { UNIT_SYMBOLS } from "../constants/nutrients";
import { useState } from "react";

const STATUS_COLORS: Record<NutrientState, string> = {
    low: "text-foreground-muted",
    met: "text-success",
    none: "text-foreground-subtle",
    ok: "text-foreground-muted",
    over: "text-danger"
};

export const NutrientRow = ({ total }: { total: NutrientTotal }) => {
    const [pointer, setPointer] = useState<{ x: number; y: number } | null>(
        null
    );

    const { dri, state, value } = total;
    const unit = UNIT_SYMBOLS[dri.unit];

    return (
        <div
            className="col-span-full grid grid-cols-subgrid hover:bg-white/4 items-center py-0.75"
            onMouseLeave={() => setPointer(null)}
            onMouseMove={(e) => setPointer({ x: e.clientX, y: e.clientY })}
        >
            <span className="text-foreground-muted truncate">{dri.name}</span>
            <NutrientBar total={total} />
            <span
                className={`tabular-nums text-right whitespace-nowrap ${state === "none" ? "text-foreground-subtle" : ""}`}
            >
                {state === "none" ? <>&mdash;</> : formatNumber(value)} {unit}
            </span>
            <span className="hidden sm:block tabular-nums text-foreground-subtle text-right">
                {dri.recommended !== null ? (
                    formatNumber(dri.recommended)
                ) : (
                    <>&le;{formatNumber(dri.upperLimit ?? 0)}</>
                )}
            </span>
            <span
                className={`tabular-nums text-right whitespace-nowrap ${STATUS_COLORS[state]}`}
            >
                {getStatusText(total)}
            </span>
            {pointer && (
                <NutrientTooltip total={total} x={pointer.x} y={pointer.y} />
            )}
        </div>
    );
};
