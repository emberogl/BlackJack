namespace BlackJack.Model
{
    /// <summary>
    /// Responsible for dealing the initial set of cards,
    /// and removing cards from the deck.
    /// </summary>
    public struct DeckHandler
    {
        public static (Card[], Card[]) DealInitialCards()
        {
            // Initializes deck and shuffles it.
            Card[] deck = Deck.InitializeDeck();
            Shuffler.ShuffleDeck(deck);

            // Hands the player and the dealer two cards.
            Card[] playerHand = { deck[0], deck[1] };
            Card[] dealerHand = { deck[2], deck[3] };

            // Removing the cards from the deck because they were given to the players.
            Remove(0, 4, ref deck);

            return (playerHand, dealerHand);
        }
        // Removes terms from array by range
        public static void Remove(int min, int max, ref Card[] deck) 
        {
            Card[] newDeck = new Card[deck.Length - (max - min)];
            Array.Copy(deck, 0, newDeck, 0, min);
            Array.Copy(deck, max, newDeck, min, deck.Length - max);

            deck = newDeck;
        }
    }
}
