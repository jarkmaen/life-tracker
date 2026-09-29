export const formatNumber = (value: number) => {
    const abs = Math.abs(value);

    return value.toLocaleString("en-US", {
        maximumFractionDigits: abs >= 100 ? 0 : abs >= 10 ? 1 : 2
    });
};
