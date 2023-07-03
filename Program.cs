using PlayingCards;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Deck deck = new();

Console.Write("How Many Players ? :");

List<Group> Players = new();

int numOfPlayers = Console.Read() - 48;

Console.WriteLine(numOfPlayers);

for(int i = 0; i < numOfPlayers; i++){
    Players.Add(new Pile());
}

deck.Shuffle(true);
deck.Deal(Players, 2);

foreach(Group player in Players){
    player.FlipAll(true);
    Console.WriteLine(player);
}