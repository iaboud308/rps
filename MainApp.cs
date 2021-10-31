using System;


namespace rps {

    class MainApp {
        
        Services service;
        OpsLogic opsLogic;
        DbService dbService;
        
        public MainApp() {
            service = new Services();
            opsLogic = new OpsLogic();
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
        }


        public void SinglePlayerMode() {
            Console.Write("Player 1 Enter your name: ");
            string PlayerOneName = Console.ReadLine();
            string PlayerTwoName = "Computer";
            string PlayerOne = service.PlayerChoice();
            string PlayerTwo = service.ComputerChoice();
            int WinnerInt = opsLogic.GetWinner(PlayerOne, PlayerTwo);
            string Winner = opsLogic.DecodeWinner(PlayerOneName, PlayerTwoName, WinnerInt);
            string PlayerOneSelection = opsLogic.DecodeSelection(PlayerOne);
            string PlayerTwoSelection = opsLogic.DecodeSelection(PlayerTwo);
            Console.WriteLine($"{PlayerOneName} chose {PlayerOneSelection} and {PlayerTwoName} chose {PlayerTwoSelection}");
            Console.WriteLine($"The Winner is: {Winner}");
            dbService.SaveGame(1, PlayerOneName, PlayerTwoName, PlayerOneSelection, PlayerTwoSelection, Winner);
            PlayAgainOption();
        }



        public void MultiPlayerMode() {
            string PlayerOneName;
            string PlayerTwoName;
            Console.Write("Player 1 Enter your name: ");
            PlayerOneName = Console.ReadLine();
            Console.Write("Player 2 Enter your name: ");
            PlayerTwoName = Console.ReadLine();
            Console.Write($"{PlayerOneName}: ");
            string PlayerOne = service.PlayerChoice();
            Console.Write($"{PlayerTwoName}: ");
            string PlayerTwo = service.PlayerChoice();
            int WinnerInt = opsLogic.GetWinner(PlayerOne, PlayerTwo);
            string Winner = opsLogic.DecodeWinner(PlayerOneName, PlayerTwoName, WinnerInt);
            string PlayerOneSelection = opsLogic.DecodeSelection(PlayerOne);
            string PlayerTwoSelection = opsLogic.DecodeSelection(PlayerTwo);
            Console.WriteLine($"{PlayerOneName} chose {PlayerOneSelection} and {PlayerTwoName} chose {PlayerTwoSelection}");
            Console.WriteLine($"The Winner is: {Winner}");
            dbService.SaveGame(2, PlayerOneName, PlayerTwoName, PlayerOneSelection, PlayerTwoSelection, Winner);
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




    }
}