

namespace rps {
    class Player {

        public string Name { get; set; }
        public int SelectionNumber { get; set; }
        public string SelectionName { get; set; }

        public Player(string name, int selectionNumber, string selectionName) {
            this.Name = name;
            this.SelectionNumber = selectionNumber;
            this.SelectionName = selectionName;
        }

    }
}