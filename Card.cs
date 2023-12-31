
namespace PlayingCards{
    public sealed class Card : Group{

        private readonly Suits suit;
        private readonly Ranks name;
        private readonly Colors color;
        private readonly byte rank = 0;
        private readonly string unicodeSuit = "";
        public Suits Suit {get{return suit;}}
        public Ranks Name {get{return name;}}
        public Colors Color {get{return color;}}
        public byte Rank {get{return rank;}}
        
        public Card(Suits suit, Ranks name, bool isFaceUp = false, bool isUnicode = false){
            this.suit = suit;
            this.name = name;
            rank = (byte)this.name;
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
            switch(suit){
                case Suits.Diamonds:
                    color = Colors.Red;
                    unicodeSuit = "♦";
                break;
                case Suits.Hearts:
                    color = Colors.Red;
                    unicodeSuit = "♥";
                break;
                case Suits.Clubs :
                    color = Colors.Black;
                    unicodeSuit = "♣";
                break;
                case Suits.Spades:
                    color = Colors.Black;
                    unicodeSuit = "♠";
                break;
            }
        }
        public override string ToString() =>
            ((isFaceUp ? 2 : 0) | (isUnicode ? 1 : 0)) switch{
            3 => $"{name} {unicodeSuit}",
            2 => $"{name} of {suit}",
            1 => "░",
            0 => "hidden",
            _ => ""
            };
    }
}