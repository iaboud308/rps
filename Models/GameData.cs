using System;


namespace rps {
    public class GameData {

        public int Id { get; set; }
        public int GameMode { get; set; }
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public string PlayerOneSelection { get; set; }
        public string PlayerTwoSelection { get; set; }
        public string Winner { get; set; }
        public DateTime Date { get; set; }

    }
}