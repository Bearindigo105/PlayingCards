using PlayingCards;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Deck deck = new(true, false);

Pile pile = new(true, false);

Console.WriteLine(deck);    //Print the contents of the deck           //Shuffle the deck

pile.Pull(deck, 0);

Console.WriteLine(pile);
Console.WriteLine(deck);