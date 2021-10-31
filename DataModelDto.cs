


namespace rps {

    class DataModelDto {

        public DataModelDto(int GameMode, string PlayerOneName, string PlayerTwoName, string PlayerOneSelection, string PlayerTwoSelection, string Winner) {
            this.GameMode = GameMode;
            this.PlayerOneName = PlayerOneName;
            this.PlayerTwoName = PlayerTwoName;
            this.PlayerOneSelection = PlayerOneSelection;
            this.PlayerTwoSelection = PlayerTwoSelection;
            this.Winner = Winner;
        }

        public int GameMode { get; set; }
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public string PlayerOneSelection{ get; set; }
        public string PlayerTwoSelection { get; set; }
        public string Winner { get; set; }

    }
}