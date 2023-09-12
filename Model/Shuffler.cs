namespace BlackJack.Model
{
    /// <summary>
    /// Deck shuffling algorithm.
    /// </summary>
    internal class Shuffler
    {
        public static void ShuffleDeck(Card[] deck)
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
