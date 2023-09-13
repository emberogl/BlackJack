namespace BlackJack.Model
{
    internal class HandValue
    {
        public static int GetHandValue(Card[] hand)
        {
            int value = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                if (card.Value == 14) // Ace
                {
                    aceCount++;
                    value += 11;
                }
                else
                {
                    value += Math.Min(card.Value, 10); // Face cards are worth 10
                }
            }

            // Adjust value for aces (1 or 11)
            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }
}