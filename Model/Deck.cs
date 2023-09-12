namespace BlackJack.Model
{
    /// <summary>
    /// Creates a deck with every possible combination of suits and values.
    /// </summary>
    public struct Deck
    {
        public static Card[] InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Card[] deck = new Card[52];
            int index = 0;

            foreach (string suit in suits)
            {
                foreach (int value in values)
                {
                    deck[index].Suit = suit;
                    deck[index].Value = value;
                    index++;
                }
            }

            return deck;
        }
    }
}