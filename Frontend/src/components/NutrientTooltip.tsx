import type { NutrientTotal } from "../types";
import { formatNumber } from "../utils/format";
import { UNIT_SYMBOLS } from "../constants/nutrients";
import { useAppContext } from "../context/useAppContext";

type Props = {
    total: NutrientTotal;
    x: number;
    y: number;
};

const OFFSET = 14;

export const NutrientTooltip = ({ total, x, y }: Props) => {
    const { appState } = useAppContext();
    const { contributions, dri, state, value } = total;
    const flipX = x > window.innerWidth / 2;
    const flipY = y > window.innerHeight / 2;
    const sorted = [...contributions].sort((a, b) => b.value - a.value);
    const unit = UNIT_SYMBOLS[dri.unit];

    return (
        <div
            className="bg-surface-sunken border border-border fixed max-w-75 pointer-events-none px-2.5 py-2 shadow-[4px_4px_0_#000] text-[11px] w-max z-50"
            style={{
                left: x + (flipX ? -OFFSET : OFFSET),
                top: y + (flipY ? -OFFSET : OFFSET),
                transform: `translate(${flipX ? "-100%" : "0"}, ${flipY ? "-100%" : "0"})`
            }}
        >
            <div className="flex font-medium gap-4.5 justify-between text-white">
                <span>{dri.name.toUpperCase()}</span>
                <span className="tabular-nums text-primary">
                    {state === "none" ? <>&mdash;</> : formatNumber(value)}{" "}
                    {unit}
                </span>
            </div>
            <hr className="border-border border-dashed my-1.25" />
            {sorted.length > 0 ? (
                sorted.map((item) => (
                    <div
                        className="flex gap-4.5 justify-between tabular-nums text-foreground-muted"
                        key={item.id}
                    >
                        <span>{item.name}</span>
                        <span>
                            {formatNumber(item.value)} {unit}
                        </span>
                    </div>
                ))
            ) : (
                <div className="text-foreground-subtle">
                    {appState.selectedMealIds.length > 0
                        ? "no value in selected meals"
                        : "no meals selected"}
                </div>
            )}
            <hr className="border-border border-dashed my-1.25" />
            <div className="text-foreground-subtle">
                {dri.recommended !== null && (
                    <>
                        rda {formatNumber(dri.recommended)} {unit}
                    </>
                )}
                {dri.recommended !== null && dri.upperLimit !== null && (
                    <> &middot; </>
                )}
                {dri.upperLimit !== null && (
                    <>
                        ul {formatNumber(dri.upperLimit)} {unit}
                    </>
                )}
            </div>
        </div>
    );
};
