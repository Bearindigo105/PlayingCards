
namespace PlayingCards{
    public sealed class Deck : Group{

        public Deck(bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;

            List<Suit> listOfSuits = new();

            for(int i = 0; i < 4; i ++){
                listOfSuits.Add(new Suit((Suits)i, this.isFaceUp, this.isUnicode));
                list.AddRange(listOfSuits[^1].List);
            }
        }
    }
}