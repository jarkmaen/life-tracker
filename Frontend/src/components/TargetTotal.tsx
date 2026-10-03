import type { NutrientTotal } from "../types";
import { formatNumber } from "../utils/format";
import { UNIT_SYMBOLS } from "../constants/nutrients";

export const TargetTotal = ({ total }: { total?: NutrientTotal }) => {
    if (!total) {
        return null;
    }

    const { dri, value } = total;

    return (
        <span>
            {dri.name.toLowerCase()}{" "}
            <b className="font-medium text-white">{formatNumber(value)}</b>{" "}
            <span className="text-foreground-subtle">
                / {formatNumber(dri.recommended ?? 0)} {UNIT_SYMBOLS[dri.unit]}
            </span>
        </span>
    );
};
