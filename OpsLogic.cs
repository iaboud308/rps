using System.Collections.Generic;


// 1 is Rock, 2 is Paper, 3 is Scissors;


namespace rps {

    class OpsLogic {

        public int GetWinner(string PlayerOneChoice, string PlayerTwoChoice) {
            int Winner = 0;

            if(PlayerOneChoice.Equals("1") && PlayerTwoChoice.Equals("1")) {
                Winner = 3;
            }

            if(PlayerOneChoice.Equals("1") && PlayerTwoChoice.Equals("2")) {
                Winner = 2;
            }

            if(PlayerOneChoice.Equals("1") && PlayerTwoChoice.Equals("3")) {
                Winner = 1;
            }

            if(PlayerOneChoice.Equals("2") && PlayerTwoChoice.Equals("1")) {
                Winner = 1;
            }

            if(PlayerOneChoice.Equals("2") && PlayerTwoChoice.Equals("2")) {
                Winner = 3;
            }

            if(PlayerOneChoice.Equals("2") && PlayerTwoChoice.Equals("3")) {
                Winner = 2;
            }

            if(PlayerOneChoice.Equals("3") && PlayerTwoChoice.Equals("1")) {
                Winner = 2;
            }

            if(PlayerOneChoice.Equals("3") && PlayerTwoChoice.Equals("2")) {
                Winner = 1;
            }

            if(PlayerOneChoice.Equals("3") && PlayerTwoChoice.Equals("3")) {
                Winner = 3;
            }


            return Winner;
        }

        public string DecodeWinner(string PlayerOneName, string PlayerTwoName, int WinnerNumber) {
            Dictionary<int, string> Decoder = new Dictionary<int, string> {

                {0, "Something went wrong"},
                {1, $"{PlayerOneName}"},
                {2, $"{PlayerTwoName}"},
                {3, "It's a tie"}
            };

            return Decoder[WinnerNumber];

        }

        public string DecodeSelection(string option) {
            Dictionary<string, string> Decoder = new Dictionary<string, string> {
                
                {"1", "Rock"},
                {"2", "Paper"},
                {"3", "Scissors"}

            };

            return Decoder[option];
        }
    }
}