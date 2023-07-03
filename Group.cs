
using System.Text;

namespace PlayingCards{
    public class Group{
        private protected List<Card> list = new();
        private protected bool isUnicode;
        private protected bool isFaceUp;
        public List<Card> List {get => list; set => list = value;}
        public bool IsUnicode { get => isUnicode; set => isUnicode = value; }
        public bool IsFaceUp { get => isFaceUp; set => isFaceUp = value; }
        public Group(List<Card> cards, bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
            list = cards;
        }
        public Group(bool isFaceUp = false, bool isUnicode = false){
            this.isFaceUp = isFaceUp;
            this.isUnicode = isUnicode;
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
        public void Pull(Group group, int index = 0, int indexTo = 0){
            Card card = group.List[index];
            list.Insert(indexTo, card);
            group.List.RemoveAt(index);
        }
        public void PullRange(Group group, int index, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(index, count);
            list.InsertRange(indexTo, cards);
            group.List.RemoveRange(index, count);
        }
        public void PullRange(Group group, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(0, count);
            list.InsertRange(indexTo, cards);
            group.List.RemoveRange(0, count);
        }
        public void Push(Group group, int index = 0, int indexTo = 0){
            Card card = list[index];
            group.List.Insert(indexTo, card);
            list.RemoveAt(index);
        }
        public void PushRange(Group group, int index, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(index, count);
            group.List.InsertRange(indexTo, cards);
            list.RemoveRange(index, count);
        }
        public void PushRange(Group group, int count = 0, int indexTo = 0){
            List<Card> cards = group.List.GetRange(0, count);
            group.List.InsertRange(indexTo, cards);
            list.RemoveRange(0, count);
        }
        public void Deal(List<Group> groups, int deal){
            for(int d = 0; d < deal; d++){
                foreach(Group group in groups){
                    Push(group);
                }
            }
        }
        public void Flip(int index = 0, bool? isFaceUp = null){
            list[index].IsFaceUp = isFaceUp != null ? isFaceUp == true : !list[index].IsFaceUp;
        }
        public void FlipAll(bool? isFaceUp = null){
            foreach(Card card in list){
                card.IsFaceUp = isFaceUp != null ? isFaceUp == true : !card.IsFaceUp;
            }
        }
    }
}
