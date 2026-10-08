import { calculateTotals } from "../utils/nutrients";
import { formatPrice } from "../utils/format";
import { StatusItem } from "./StatusItem";
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
    const price = meals
        .filter((meal) => selectedMealIds.includes(meal.id))
        .reduce((sum, meal) => sum + meal.price, 0);

    const find = (key: string) => totals.find((total) => total.dri.key === key);

    return (
        <footer className="bg-surface-sunken border-black border-t flex-none lg:flex lg:flex-wrap lg:gap-4 lg:items-center lg:justify-between lg:min-h-7.5 lg:pr-5">
            <div className="lg:flex lg:flex-wrap lg:gap-4 lg:items-center">
                <span className="bg-primary font-bold hidden lg:block px-3 py-1.75 text-[11px] text-black tracking-[0.06em]">
                    TODAY
                </span>
                <div className="grid grid-cols-6 lg:flex lg:flex-wrap lg:gap-x-5 lg:gap-y-1 text-foreground-muted">
                    <TargetTotal
                        className="col-span-3"
                        total={find("energy")}
                    />
                    <TargetTotal
                        className="border-l col-span-3"
                        total={find("protein")}
                    />
                    <StatusItem
                        className="border-t col-span-2"
                        label="targets met"
                    >
                        <b className="font-medium text-white">
                            {met}/{targets.length}
                        </b>
                    </StatusItem>
                    <StatusItem
                        className="border-l border-t col-span-2"
                        label="over limit"
                    >
                        <b
                            className={`font-medium ${over > 0 ? "text-danger" : "text-white"}`}
                        >
                            {over}
                        </b>
                    </StatusItem>
                    <StatusItem
                        className="border-l border-t col-span-2"
                        label="cost"
                    >
                        <b className="font-medium text-white">
                            {formatPrice(price)}
                        </b>
                    </StatusItem>
                </div>
            </div>
            <div className="gap-4 hidden text-[11px] text-foreground-muted xl:flex">
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
