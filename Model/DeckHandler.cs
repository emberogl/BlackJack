namespace BlackJack.Model
{
    /// <summary>
    /// Responsible for dealing the initial set of cards.
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

            return (playerHand, dealerHand);
        }
    }
}
