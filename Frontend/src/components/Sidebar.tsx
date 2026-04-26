import SidebarItem from "./SidebarItem";

const Sidebar = () => {
    return (
        <div className="bg-[#1a1a1a] border-black border-r flex flex-col text-gray-400 w-48">
            <div className="border-b border-white/10 font-black italic p-4 text-lg text-white tracking-tighter">
                LIFE TRACKER
            </div>
            <div className="py-4 space-y-1">
                <SidebarItem label="EXERCISES" to="/exercises" />
                <SidebarItem label="HABITS" to="/habits" />
                <SidebarItem label="NUTRIENTS" to="/nutrients" />
            </div>
        </div>
    );
};

export default Sidebar;
