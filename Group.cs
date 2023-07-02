using System.Text;

namespace PlayingCards{
    public class Group{
        private protected readonly List<Card> list = new();
        private protected bool isUnicode;
        private protected bool isFaceUp;
        public List<Card> List => list;
        public bool IsUnicode { get => isUnicode; set => isUnicode = value; }
        public bool IsFaceUp { get => isFaceUp; set => isFaceUp = value; }
        public Group(List<Card>? cards = default, bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
            if(cards != null){
                list = cards;
            }
        }
        public override string ToString(){
            StringBuilder sb = new("", list.Capacity * 10);
            foreach(Card card in list){
                sb.Append(card);
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public void Shuffle(bool verbose = false){
            Console.Write(verbose ? "Shuffling... \n\n" : null);
            list.Sort(RandomCompare);
            list.Sort(RandomCompare);
            list.Sort(RandomCompare);
        }
        public Card Pick(int index = -1){
            Random random = new();
            return index switch{
                -1 => list[random.Next(list.Count)],
                _ => list[index]
            };
        }
        public Card PickExtreme(bool isTop = true){
            return list[isTop ? 0 : list.Count - 1];
        }
        private int RandomCompare(Card x, Card y){
            Random rand = new();
            return rand.Next(-26,26);
        }
    }
}
