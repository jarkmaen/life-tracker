import type { ReactNode } from "react";

type Props = {
    children: ReactNode;
    className?: string;
    label: string;
};

export const StatusItem = ({ children, className = "", label }: Props) => {
    return (
        <div
            className={`border-border flex flex-col gap-px lg:block lg:border-0 lg:p-0 pb-2 pt-1.75 px-3 ${className}`}
        >
            <span className="lg:normal-case lg:text-foreground-muted lg:text-xs lg:tracking-normal text-[10.5px] text-foreground-subtle tracking-[0.06em] uppercase">
                {label}
            </span>{" "}
            <span className="whitespace-nowrap">{children}</span>
        </div>
    );
};
