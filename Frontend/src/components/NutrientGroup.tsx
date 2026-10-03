import type { NutrientTotal } from "../types";
import { NutrientRow } from "./NutrientRow";

type Props = {
    label: string;
    totals: NutrientTotal[];
};

export const NutrientGroup = ({ label, totals }: Props) => {
    return (
        <div className="pb-3">
            <div className="border-b border-border gap-3 grid grid-cols-[150px_minmax(80px,1fr)_88px_56px_48px] items-center mb-0.75 min-w-117.5 pb-1 pt-2 text-[10.5px] text-foreground-subtle tracking-[0.06em]">
                <span className="text-primary tracking-[0.08em]">{label}</span>
                <span />
                <span className="text-right">AMOUNT</span>
                <span className="text-right">RDA</span>
                <span className="text-right">%</span>
            </div>
            {totals.map((total) => (
                <NutrientRow key={total.dri.key} total={total} />
            ))}
        </div>
    );
};
