import type { NutrientTotal } from "../types";
import { NutrientRow } from "./NutrientRow";

type Props = {
    label: string;
    totals: NutrientTotal[];
};

export const NutrientGroup = ({ label, totals }: Props) => {
    return (
        <div className="col-span-full grid grid-cols-subgrid pb-3">
            <div className="border-b border-border col-span-full grid grid-cols-subgrid items-center mb-0.75 pb-1 pt-2 text-[10.5px] text-foreground-subtle tracking-[0.06em]">
                <span className="col-span-2 text-primary tracking-[0.08em]">
                    {label}
                </span>
                <span className="text-right">AMOUNT</span>
                <span className="hidden sm:block text-right">RDA</span>
                <span className="text-right">%</span>
            </div>
            {totals.map((total) => (
                <NutrientRow key={total.dri.key} total={total} />
            ))}
        </div>
    );
};
