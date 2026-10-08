import type { ReactNode } from "react";

type Props = {
    children: ReactNode;
    className?: string;
    label: string;
};

export const StatusItem = ({ children, className = "", label }: Props) => {
    return (
        <div
            className={`border-border flex flex-col gap-px md:block md:border-0 md:p-0 pb-2 pt-1.75 px-3 ${className}`}
        >
            <span className="md:normal-case md:text-foreground-muted md:text-xs md:tracking-normal text-[10.5px] text-foreground-subtle tracking-[0.06em] uppercase">
                {label}
            </span>{" "}
            <span className="whitespace-nowrap">{children}</span>
        </div>
    );
};
