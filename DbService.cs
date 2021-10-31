using System;

namespace rps {
    class DbService {

        GameContext context;
        
        public DbService() {
            context = new GameContext();
        }

        public void GetAll() {
            // context.GameData

        }


        public void Get(int Id) {

        }


        public void SaveGame(int GameMode, string PlayerOneName, string PlayerTwoName, string PlayerOneSelection, string PlayerTwoSelection, string Winner) {

            DataModel GameData = new DataModel();
            GameData.GameMode = GameMode;
            GameData.PlayerOneName = PlayerOneName;
            GameData.PlayerTwoName = PlayerTwoName;
            GameData.PlayerOneSelection = PlayerOneSelection;
            GameData.PlayerTwoSelection = PlayerTwoSelection;
            GameData.Winner = Winner;
            GameData.Date = DateTime.Now;

            context.Add(GameData);
            context.SaveChanges();

        }


    }
}