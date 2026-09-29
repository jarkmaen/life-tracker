import MealList from "./MealList";

const Sidebar = () => {
    return (
        <aside className="bg-surface border-b border-black flex flex-col flex-none md:border-b-0 md:border-r md:w-57.5">
            <div className="border-b border-white/10 font-extrabold italic p-4 text-[17px] text-white tracking-[-0.04em]">
                NUTRIENT TRACKER
            </div>
            <MealList />
        </aside>
    );
};

export default Sidebar;
