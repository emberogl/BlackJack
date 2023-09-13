using BlackJack.Model;
using BlackJack.View;

namespace BlackJack.Controller
{
    public class Cycle
    {
        public void StartGame() {

            // Creates a deck, shuffles that deck, and hands the player and the dealer two cards.
            (Card[] playerHand, Card[] dealerHand) = DeckHandler.DealInitialCards();

            // Displays the given cards to console.
            Interface.DisplayCards(playerHand, dealerHand[0]);

            // Asks the player to either hit or stand.
            string playerAction = Interface.AskForPlayerAction();
        }
    }
}