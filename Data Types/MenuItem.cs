

namespace rps {
    class MenuItem {
        public int MenuItemNumber { get; }
        public string MenuItemName {get; }

        public MenuItem(int number, string name) {
            this.MenuItemNumber = number;
            this.MenuItemName = name;
        }

    }
}
