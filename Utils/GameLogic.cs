using System;
using System.Collections.Generic;

// 1 is Rock, 2 is Paper, 3 is Scissors;


namespace rps {

    class GameLogic {

        public string GetWinner(Player PlayerOne, Player PlayerTwo) {
            string Winner = "";

            if(PlayerOne.SelectionNumber == 1 && PlayerTwo.SelectionNumber == 1) {
                Winner = "Tie";
            }

            if(PlayerOne.SelectionNumber == 1 && PlayerTwo.SelectionNumber == 2) {
                Winner = PlayerTwo.Name;
            }

            if(PlayerOne.SelectionNumber == 1 && PlayerTwo.SelectionNumber == 3) {
                Winner = PlayerOne.Name;
            }

            if(PlayerOne.SelectionNumber == 2 && PlayerTwo.SelectionNumber == 1) {
                Winner = PlayerOne.Name;
            }

            if(PlayerOne.SelectionNumber == 2 && PlayerTwo.SelectionNumber == 2) {
                Winner = "Tie";
            }

            if(PlayerOne.SelectionNumber == 2 && PlayerTwo.SelectionNumber == 3) {
                Winner = PlayerTwo.Name;
            }

            if(PlayerOne.SelectionNumber == 3 && PlayerTwo.SelectionNumber == 1) {
                Winner = PlayerTwo.Name;
            }

            if(PlayerOne.SelectionNumber == 3 && PlayerTwo.SelectionNumber == 2) {
                Winner = PlayerOne.Name;
            }

            if(PlayerOne.SelectionNumber == 3 && PlayerTwo.SelectionNumber == 3) {
                Winner = "Tie";
            }

            Console.WriteLine($"{PlayerOne.Name} chose {PlayerOne.SelectionName} and {PlayerTwo.Name} chose {PlayerTwo.SelectionName}");
            Console.WriteLine($"The winner is {Winner}");
            return Winner;
        }




        // Alternative function
        // 1 is Rock, 2 is Paper and 3 is Scissors on the first and second values. On the third value, 1 means player 1 is the winner, 2 means player 2 is the winner and 0
        // means its a tie.
        public string GetWinner2(Player PlayerOne, Player PlayerTwo) {
    
            int[,] logicArray = new int[9, 3] { { 1, 1, 0 }, { 1, 2, 2 }, { 1, 3, 1 }, { 2, 1, 1 }, { 2, 2, 0 }, { 2, 3, 2 }, { 3, 1, 2 }, { 3, 2, 1 }, { 3, 3, 0 } };
            int winner = Convert.ToInt32(logicArray.GetValue(PlayerOne.SelectionNumber, PlayerTwo.SelectionNumber));

            string winnerText = GetWinnerInTextFormat(winner);

            Console.WriteLine($"{PlayerOne.Name} chose {PlayerOne.SelectionName} and {PlayerTwo.Name} chose {PlayerTwo.SelectionName}");
            Console.WriteLine($"The winner is {winnerText}");

            return winnerText;
        }


        public string GetWinnerInTextFormat(int winnerInt) {
            Dictionary<int, string> Converter = new Dictionary<int, string> {
                {0, "Tie"},
                {1, "Player 1"},
                {2, "Player 2"}
            };

            return Converter[winnerInt];
        }

        // Alternative function
        public string GetWinner3(Player PlayerOne, Player PlayerTwo) {
            
            WinningType[] WinningType = {
                new WinningType("Rock", "Rock", "Tie"),
                new WinningType("Rock", "Paper" , PlayerTwo.Name),
                new WinningType("Rock", "Scissors", PlayerOne.Name),
                new WinningType("Paper", "Rock", PlayerOne.Name),
                new WinningType("Paper", "Paper", "Tie"),
                new WinningType("Paper", "Scissors", PlayerTwo.Name),
                new WinningType("Scissors", "Rock", PlayerTwo.Name),
                new WinningType("Scissors", "Paper", PlayerOne.Name),
                new WinningType("Scissors", "Scissors", "Tie")
            };

            WinningType Winner = Array.Find<WinningType>(WinningType, WT => WT.PlayerOneSelection.Equals(PlayerOne.SelectionName) && WT.PlayerTwoSelection.Equals(PlayerTwo.SelectionName));
            Console.WriteLine($"{PlayerOne.Name} chose {PlayerOne.SelectionName} and {PlayerTwo.Name} chose {PlayerTwo.SelectionName}");
            Console.WriteLine($"The winner is {Winner.WinnerText}");
            return Winner.WinnerText;

        }



    }
}