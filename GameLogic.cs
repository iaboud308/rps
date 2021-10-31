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


            return Winner;
        }


    }
}