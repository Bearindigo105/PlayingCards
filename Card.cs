
namespace PlayingCards{
    public sealed class Card : Group{
        public Suits Suit { get; }
        public string? UnicodeSuit { get; }
        public new Ranks Name { get; }
        public Colors Color { get; }
        public byte Rank { get; }
        
        public Card(Suits suit, Ranks name, bool isFaceUp = false, bool isUnicode = false){
            Suit = suit;
            Name = name;
            Rank = (byte)Name;
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
            switch(suit){
                case Suits.Diamonds:
                    Color = Colors.Red;
                    UnicodeSuit = "♦";
                break;
                case Suits.Hearts:
                    Color = Colors.Red;
                    UnicodeSuit = "♥";
                break;
                case Suits.Clubs :
                    Color = Colors.Black;
                    UnicodeSuit = "♣";
                break;
                case Suits.Spades:
                    Color = Colors.Black;
                    UnicodeSuit = "♠";
                break;
            }
        }
        public override string ToString() =>
            ((IsFaceUp ? 2 : 0) | (IsUnicode ? 1 : 0)) switch{
            3 => $"{Name} {UnicodeSuit}",
            2 => $"{Name} of {Suit}",
            1 => "░",
            0 => "hidden",
            _ => ""
            };
    }
}