
namespace PlayingCards{
    public sealed class Suit : Group{
        
        public Suit(Suits suit, bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;

            for(int i = 1; i < 14; i ++){
                list.Add(new Card(suit, (Names)i, this.isFaceUp, this.isUnicode));
            }
        }
    }
}
