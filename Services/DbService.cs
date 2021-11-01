using System;

namespace rps {
    class DbService {

        GameContext context;
        
        public DbService() {
            context = new GameContext();
        }

        public void GetAll() {
            var GameLogs = context.GameData;
            foreach(var log in GameLogs) {
                Console.WriteLine($"{log.Id} |  {log.PlayerOneName}  |  {log.PlayerOneSelection}  |  {log.PlayerTwoName}  |  {log.PlayerTwoSelection} |  {log.Winner}  |  {log.Date}");
            }

        }



        public void SaveGame(int GameMode, Player PlayerOne, Player PlayerTwo, string Winner) {

            GameData GameData = new GameData();
            GameData.GameMode = GameMode;
            GameData.PlayerOneName = PlayerOne.Name;
            GameData.PlayerTwoName = PlayerTwo.Name;
            GameData.PlayerOneSelection = PlayerOne.SelectionName;
            GameData.PlayerTwoSelection = PlayerTwo.SelectionName;
            GameData.Winner = Winner;
            GameData.Date = DateTime.Now;

            context.Add(GameData);
            context.SaveChanges();

        }


    }
}