using System;
using System.Linq;
using System.Collections.Generic;


namespace rps {

    class Service {

        public string PlayerResponse;
        public MenuItem[] ValidOptionsMainMenu = { new MenuItem(1, "Single Player"), new MenuItem(2, "Two Player"), new MenuItem(3, "Quit"), new MenuItem(4, "View Game Logs") } ;
        public MenuItem[] ValidOptionsPlayerChoice = { new MenuItem(1, "Rock"), new MenuItem(2, "Paper"), new MenuItem(3, "Scissors") };
        

        public string MainMenu() {

            bool IsValid = false;
            while(!IsValid) {
                Console.WriteLine("Please choose one of the following options: ");
                foreach(MenuItem item in ValidOptionsMainMenu) {
                    Console.WriteLine($"{item.MenuItemNumber} - {item.MenuItemName}");
                }
                PlayerResponse = Console.ReadLine();
                if(Array.Exists(ValidOptionsMainMenu, item => item.MenuItemNumber.ToString().Equals(PlayerResponse))) {
                    IsValid = true;
                    break;
                }
                    Console.WriteLine("Please enter a valid response");
            }
            return PlayerResponse;
        }


        public Player PlayerChoice() {
            bool IsValid = false;
            Console.Write("Enter player name: ");
            string PlayerName = Console.ReadLine();
            while(!IsValid) {
                Console.WriteLine($"{PlayerName} Please choose one of the following options: ");
                foreach(MenuItem item in ValidOptionsPlayerChoice) {
                    Console.WriteLine($"{item.MenuItemNumber} - {item.MenuItemName}");
                }
                PlayerResponse = Console.ReadLine();
                if(Array.Exists(ValidOptionsPlayerChoice, item => item.MenuItemNumber.ToString().Equals(PlayerResponse))) {
                    IsValid = true;
                } else {
                    Console.WriteLine("Please enter a valid response");
                }
            }

            MenuItem PlayerChoice = Array.Find<MenuItem>(ValidOptionsPlayerChoice, choice => choice.MenuItemNumber.ToString().Equals(PlayerResponse));
            return  new Player(PlayerName, PlayerChoice.MenuItemNumber, PlayerChoice.MenuItemName);
        }

        public Player ComputerChoice() {
            Random random = new Random();
            int ComputerSelection = random.Next(1, 4);
            MenuItem ComputerChoice = Array.Find<MenuItem>(ValidOptionsPlayerChoice, choice => choice.MenuItemNumber == ComputerSelection);
            return new Player("Computer", ComputerChoice.MenuItemNumber, ComputerChoice.MenuItemName);
        }
    }
}