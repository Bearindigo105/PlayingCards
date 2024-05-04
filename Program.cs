
using PlayingCards;

internal class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new();
        List<Group> players = new();


        Console.Write("How many players?: ");
        deck.Shuffle();
        int playerCount = int.Parse(Console.ReadLine() ?? "1");
        while (Console.KeyAvailable) { }
        Console.WriteLine(playerCount);
        
        players.Add(new Group("dealer"));

        for (int index = 0; index < playerCount; index++)
        {
            players.Add(new Group("player " + (index + 1).ToString()));
        }

        deck.Deal(players, 2);

        foreach (Group player in players)
        {
            player.FlipAll();
            Console.WriteLine(player);
        }
        
        for (int i = 0; i < players.Count; i++)
        {
            turn(players[i], deck);
            if (players[i] == null)
            {
                players.Remove(players[i]);
            }
        }

        static void turn(Group? player, Deck deck)
        {
            if(player == null) { return; }
            Console.Write("Hit(h) or Fold(f)?: ");
            string? move = Console.ReadLine();
            while (!(move == "h" | move == "f"))
            {
                Console.Write("No. Hit(h) or Fold(f)?: ");
                move = Console.ReadLine();
            }
            while (Console.KeyAvailable) { }
            Console.Write("\n");
            switch (move)
            {
                case "h":
                    player.Pull(deck);
                    player.Flip();
                    break;
                case "f":
                    player = null;
                    break;
                default:
                    break;
            }
            Console.Write(player);
        }
    }
}