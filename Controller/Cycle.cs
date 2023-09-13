using BlackJack.Model;
using BlackJack.View;

namespace BlackJack.Controller
{
    public class Cycle
    {
        public void StartGame() {
            while (true)
            {
                // Creates a deck, shuffles that deck, and hands the player and the dealer two cards.
                (Card[] playerHand, Card[] dealerHand, Card[] deck) = DeckHandler.DealInitialCards();

                // Displays the given cards to console.
                Interface.DisplayCards(playerHand, dealerHand[0]);

                // Asks the player to either hit or stand.
                string playerAction = Interface.AskForPlayerAction();

                while (playerAction == "hit")
                {
                    bool continueGame = PlayerInteraction.Hit(ref playerHand, dealerHand, ref deck);
                    if (!continueGame)
                    {
                        Console.ReadKey();
                        StartGame(); // End the game if the player busted.
                    }
                    Interface.DisplayCards(playerHand, dealerHand[0]);
                    playerAction = Interface.AskForPlayerAction();
                }
                if (playerAction == "stand")
                {
                    PlayerInteraction.Stand(playerHand, dealerHand, deck);
                }
                Console.ReadKey();
            }
        }
    }
}