using System;


namespace rps {

    class MainApp {
        
        Service service;
        GameLogic gameLogic;
        DbService dbService;
        
        public MainApp() {
            service = new Service();
            gameLogic = new GameLogic();
            dbService = new DbService();
        }       

        public void Start() {
            string PlayerSelection = service.MainMenu();
            HandleMainMenuResponse(PlayerSelection);
            
        }


        public void HandleMainMenuResponse(string PlayerSelection) {
            if(PlayerSelection.Equals("1")) {
                SinglePlayerMode();
            }

            if(PlayerSelection.Equals("2")) {
                MultiPlayerMode();
            }

            if(PlayerSelection.Equals("3")) {
                Console.WriteLine("Bye bye");
            }

            if(PlayerSelection.Equals("4")) {
                ViewGameLogs();
            }
        }


        public void SinglePlayerMode() {
            Player PlayerOne = service.PlayerChoice();
            Player PlayerTwo = service.ComputerChoice();
            string Winner = gameLogic.GetWinner(PlayerOne, PlayerTwo);
            Console.WriteLine($"{PlayerOne.Name} chose {PlayerOne.SelectionName} and {PlayerTwo.Name} chose {PlayerTwo.SelectionName}");
            Console.WriteLine($"The Winner is: {Winner}");
            dbService.SaveGame(1, PlayerOne, PlayerTwo, Winner);
            PlayAgainOption();
        }



        public void MultiPlayerMode() {
            Player PlayerOne = service.PlayerChoice();
            Player PlayerTwo = service.PlayerChoice();
            string Winner = gameLogic.GetWinner(PlayerOne, PlayerTwo);
            Console.WriteLine($"{PlayerOne.Name} chose {PlayerOne.SelectionName} and {PlayerTwo.Name} chose {PlayerTwo.SelectionName}");
            Console.WriteLine($"The Winner is: {Winner}");
            dbService.SaveGame(2, PlayerOne, PlayerTwo, Winner);
            PlayAgainOption();
        }


        public void PlayAgainOption() {
            string PlayerResponse;
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No thanks");
            PlayerResponse = Console.ReadLine();

            if(PlayerResponse.Equals("1")) {
                Start();
            }

        }

        public void ViewGameLogs() {
            Console.WriteLine("Id | P1 Name | P1 Selection | P2 Name | P2 Selection | Winner | Date | Time ");
            dbService.GetAll();
        }




    }
}