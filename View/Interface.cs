using BlackJack.Model;

namespace BlackJack.View
{
    /// <summary>
    /// Main view class for handling user interface.
    /// </summary>
    public class Interface
    {
        // Displays player's cards in hand.
        public static void DisplayCards(Card[] playerHand, Card dealerCard)
        {
            Console.Clear();
            Console.WriteLine("Your cards are:");
            foreach (Card card in playerHand)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("\nDealer's visible card is:");
            Console.WriteLine(dealerCard.ToString());
        }

        // Displays the dealer's cards in hand.
        public static string AskForPlayerAction()
        {
            Console.WriteLine("\nDo you want to hit or stand?");
            string action = Console.ReadLine()!.ToLower();
            while (action != "hit" && action != "stand")
            {
                Console.WriteLine("Invalid input. Please enter 'hit' or 'stand'.");
                action = Console.ReadLine()!.ToLower();
            }
            return action;
        }

        // Result output.
        public static void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
