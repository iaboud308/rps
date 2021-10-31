using System;
using System.Linq;


namespace rps {
    class Services {

        public string PlayerResponse;
        public string[] ValidOptionsMainMenu = {"1", "2", "3"};
        public string[] ValidOptionsPlayerChoice = {"1", "2", "3", "4"};

        public string MainMenu() {

            bool IsValid = false;

            while(!IsValid) {

                Console.WriteLine("Please choose one of the following options: ");
                Console.WriteLine("1 - Single Player");
                Console.WriteLine("2 - Two Players");
                Console.WriteLine("3 - Quit Game");
                PlayerResponse = Console.ReadLine();
                if(ValidOptionsMainMenu.Contains(PlayerResponse)) {
                    IsValid = true;
                    break;
                }
                    Console.WriteLine("Please enter a valid response");
            }
            return PlayerResponse;
        }


        public string PlayerChoice() {
            bool IsValid = false;

            while(!IsValid) {
                Console.WriteLine("Please choose one of the following options: ");
                Console.WriteLine("1 - Rock");
                Console.WriteLine("2 - Paper");
                Console.WriteLine("3 - Scissors");
                Console.WriteLine("4 - Back to main menu");
                PlayerResponse = Console.ReadLine();
                if(ValidOptionsPlayerChoice.Contains(PlayerResponse)) {
                    IsValid = true;
                    break;
                }
                Console.WriteLine("Please enter a valid response");
            }

            return PlayerResponse;
        }

        public string ComputerChoice() {
            Random random = new Random();
            string ComputerSelection = random.Next(1, 4).ToString();
            return ComputerSelection;
        }
    }
}