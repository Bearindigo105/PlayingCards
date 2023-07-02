
namespace PlayingCards{
    public sealed class Pile : Group{
        public Pile(List<Card> cards, bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
            if(cards != null){
                list = cards;
            }
        }
        public Pile(bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
        }
    }
}