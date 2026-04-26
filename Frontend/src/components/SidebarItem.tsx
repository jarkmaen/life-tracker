import { NavLink, useLocation } from "react-router-dom";

type Props = {
    label: string;
    to: string;
};

const SidebarItem = ({ label, to }: Props) => {
    const { pathname } = useLocation();

    const shouldHighlight = (isActive: boolean) => {
        if (isActive) {
            return true;
        }

        if (pathname === "/" && to === "/nutrients") {
            return true;
        }

        return false;
    };

    return (
        <NavLink
            className={({ isActive }) =>
                `${
                    shouldHighlight(isActive)
                        ? "bg-white/5 border-orange-500 border-r-2 text-white"
                        : "text-gray-400"
                } block hover:text-white px-4 py-2 transition-colors`
            }
            to={to}
        >
            {label}
        </NavLink>
    );
};

export default SidebarItem;
