

namespace rps {
    class WinningType {
        public string PlayerOneSelection { get; set; }
        public string PlayerTwoSelection { get; set; }
        public string WinnerText { get; set; }

        public WinningType(string PlayerOneSelection, string PlayerTwoSelection, string WinnerText) {
            this.PlayerOneSelection = PlayerOneSelection;
            this.PlayerTwoSelection = PlayerTwoSelection;
            this.WinnerText = WinnerText;
        }

    }
}