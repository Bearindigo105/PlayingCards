
namespace PlayingCards{
    public sealed class Deck : Group{
        public Deck(bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
            
            for(int suit = 0; suit < 4; suit++){
                for(int rank = 1; rank < 14; rank++)
                list.Add(new Card((Suits)suit, (Ranks)rank, isFaceUp, isUnicode));
            }
        }
    }
}