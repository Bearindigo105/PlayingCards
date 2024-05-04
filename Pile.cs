
namespace PlayingCards{
    public sealed class Pile : Group{
        public Pile(List<Card> cards, bool isFaceUp = false, bool isUnicode = false){
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
            if(cards != null){
                List = cards;
            }
        }
        public Pile(bool isFaceUp = false, bool isUnicode = false){
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
        }
    }
}