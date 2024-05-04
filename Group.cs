
using System.Text;

namespace PlayingCards{
    public class Group{
        public List<Card> List { get; set; }
        public bool IsUnicode { get; set; }
        public bool IsFaceUp { get; set; }
        public string? Name { get; set; }
        public Group(List<Card> cards, string? name = null,bool isFaceUp = false, bool isUnicode = false){
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
            List = cards;
            Name = name;
        }
        public Group(string? name = null, bool isFaceUp = false, bool isUnicode = false)
        {
            IsFaceUp = isFaceUp;
            IsUnicode = isUnicode;
            List = new();
            Name = name;
        }
        public override string ToString(){
            StringBuilder sb = new("", List.Capacity * 10);
            sb.Append(Name);
            sb.Append(": \n");
            foreach(Card card in List){
                sb.Append(card);
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public void Shuffle(bool verbose = false){
            Console.Write(verbose ? "Shuffling... \n\n" : null);
            Random random = new();
            
            int len = List.Count;
            while(len > 1){
                len --;
                int rIndex = random.Next(len +1);
                (List[len], List[rIndex]) = (List[rIndex], List[len]);
            }
        }
        public Card Pick(int index = -1){
            Random random = new();
            return index switch{
                -1 => List[random.Next(List.Count)],
                _ => List[index]
            };
        }
        public Card PickExtreme(bool isTop = true){
            return List[isTop ? 0 : List.Count - 1];
        }
        public void Pull(Group group, int index = 0, int indexTo = 0){
            Card card = group.List[index];
            List.Insert(indexTo, card);
            group.List.RemoveAt(index);
        }
        public void PullRange(Group group, int index, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(index, count);
            List.InsertRange(indexTo, cards);
            group.List.RemoveRange(index, count);
        }
        public void PullRange(Group group, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(0, count);
            List.InsertRange(indexTo, cards);
            group.List.RemoveRange(0, count);
        }
        public void Push(Group group, int index = 0, int indexTo = 0){
            Card card = List[index];
            group.List.Insert(indexTo, card);
            List.RemoveAt(index);
        }
        public void PushRange(Group group, int index, int count, int indexTo = 0){
            List<Card> cards = group.List.GetRange(index, count);
            group.List.InsertRange(indexTo, cards);
            List.RemoveRange(index, count);
        }
        public void PushRange(Group group, int count = 0, int indexTo = 0){
            List<Card> cards = group.List.GetRange(0, count);
            group.List.InsertRange(indexTo, cards);
            List.RemoveRange(0, count);
        }
        public void Deal(List<Group> groups, int deal){
            for(int d = 0; d < deal; d++){
                foreach(Group group in groups){
                    Push(group);
                }
            }
        }
        public void Flip(int index = 0, bool? isFaceUp = null){
            List[index].IsFaceUp = isFaceUp != null ? isFaceUp == true : !List[index].IsFaceUp;
        }
        public void FlipAll(bool? isFaceUp = null){
            foreach(Card card in List){
                card.IsFaceUp = isFaceUp != null ? isFaceUp == true : !card.IsFaceUp;
            }
        }
    }
}
