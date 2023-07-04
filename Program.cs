
using PlayingCards;

Deck deck = new();

List<Group> players = new();

Console.Write("How many players?: ");

deck.Shuffle();

int playerCount = int.Parse(Console.ReadLine() ?? "1");

while(Console.KeyAvailable){}

Console.WriteLine(playerCount);

for (int index = 0; index < playerCount; index ++){
    players.Add(new Group());
}

deck.Deal(players, 2);

foreach(Group player in players){
    player.FlipAll();
    Console.WriteLine(player);
}

foreach(Group player in players){
    turn(player);
    
}

static void turn(Group player){
    Console.Write("Hit(h) or Fold(f)?: ");
    string? move = Console.ReadLine();
    while(!(move == "h" | move == "f")){
        Console.Write("No. Hit(h) or Fold(f)?: ");
        move = Console.ReadLine();
    }
    while(Console.KeyAvailable){}
    Console.Write("\n");
}