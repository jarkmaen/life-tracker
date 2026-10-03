import { calculateTotals } from "../utils/nutrients";
import { TargetTotal } from "./TargetTotal";
import { useAppContext } from "../context/useAppContext";

export const StatusBar = () => {
    const { appState } = useAppContext();
    const { dri, meals, selectedMealIds } = appState;

    const totals = calculateTotals(dri, meals, selectedMealIds);

    const targets = totals.filter(
        (total) => total.dri.recommended !== null && total.state !== "none"
    );

    const met = targets.filter(
        (total) => total.value >= (total.dri.recommended ?? 0)
    ).length;
    const over = totals.filter((total) => total.state === "over").length;

    const find = (key: string) => totals.find((total) => total.dri.key === key);

    return (
        <footer className="bg-surface-sunken border-black border-t flex flex-none flex-wrap gap-4 items-center justify-between min-h-7.5 pr-5">
            <div className="flex flex-wrap gap-4 items-center">
                <span className="bg-primary font-bold px-3 py-1.75 text-[11px] text-black tracking-[0.06em]">
                    TODAY
                </span>
                <div className="flex flex-wrap gap-x-5 gap-y-1 text-foreground-muted">
                    <TargetTotal total={find("energy")} />
                    <TargetTotal total={find("protein")} />
                    <span>
                        targets met{" "}
                        <b className="font-medium text-white">
                            {met}/{targets.length}
                        </b>
                    </span>
                    <span>
                        over limit{" "}
                        <b
                            className={`font-medium ${over > 0 ? "text-danger" : "text-white"}`}
                        >
                            {over}
                        </b>
                    </span>
                </div>
            </div>
            <div className="flex gap-4 text-[11px] text-foreground-muted">
                <span className="flex gap-1.5 items-center">
                    <i className="bg-white h-2.75 w-0.5" />
                    recommended
                </span>
                <span className="flex gap-1.5 items-center">
                    <i className="bar-limit h-2.75 w-0.5" />
                    upper limit
                </span>
            </div>
        </footer>
    );
};
