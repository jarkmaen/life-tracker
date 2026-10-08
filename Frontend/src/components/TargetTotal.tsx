import type { NutrientTotal } from "../types";
import { formatNumber } from "../utils/format";
import { StatusItem } from "./StatusItem";
import { UNIT_SYMBOLS } from "../constants/nutrients";

type Props = {
    className?: string;
    total?: NutrientTotal;
};

export const TargetTotal = ({ className, total }: Props) => {
    if (!total) {
        return null;
    }

    const { dri, value } = total;

    return (
        <StatusItem className={className} label={dri.name.toLowerCase()}>
            <b className="font-medium text-white">{formatNumber(value)}</b>{" "}
            <span className="text-foreground-subtle">
                / {formatNumber(dri.recommended ?? 0)} {UNIT_SYMBOLS[dri.unit]}
            </span>
        </StatusItem>
    );
};
