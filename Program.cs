using PlayingCards;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Deck deck = new(true, false);

Console.WriteLine(deck);    //Print the contents of the deck           //Shuffle the deck
Console.WriteLine(deck);    //Reprint the contents of the deck after shuffling

Console.WriteLine(deck.Pick());