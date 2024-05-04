
namespace PlayingCards{
    public sealed class Deck : Group{
        public Deck(bool isFaceUp = false, bool isUnicode = false){
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
            
            for(int suit = 0; suit < 4; suit++){
                for(int rank = 1; rank < 14; rank++)
                List.Add(new Card((Suits)suit, (Ranks)rank, isFaceUp, isUnicode));
            }
        }
    }
}