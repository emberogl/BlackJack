using BlackJack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    internal class PlayerInteraction
    {
        public static bool Hit(ref Card[] playerHand, Card[] dealerHand, ref Card[] deck)
        {
            // Add a card from the deck to the player's hand and remove it from the deck.
            Array.Resize(ref playerHand, playerHand.Length + 1);
            playerHand[playerHand.Length - 1] = deck[0];
            DeckHandler.Remove(0, 1, ref deck);

            // Check if player busted
            if (HandValue.GetHandValue(playerHand) > 21)
            {
                Interface.DisplayResult("\nYou busted! Dealer wins.");
                Interface.DisplayResult("\nYour hand:");
                foreach (Card card in playerHand)
                {
                    Interface.DisplayResult(card.ToString());
                }
                return false;
            }
            return true;
        }

        public static void Stand(Card[] playerHand, Card[] dealerHand, Card[] deck)
        {
            // Reveal dealer's full hand and decide the winner
            Interface.DisplayCards(playerHand, dealerHand[1]); // Display dealer's second card.

            int playerHandValue = HandValue.GetHandValue(playerHand);
            int dealerHandValue = HandValue.GetHandValue(dealerHand);

            // Dealer hits until they have at least 17
            while (dealerHandValue < 17)
            {
                // Add a card from the deck to the dealer's hand and remove it from the deck.
                Array.Resize(ref dealerHand, dealerHand.Length + 1);
                dealerHand[dealerHand.Length - 1] = deck[0];
                DeckHandler.Remove(0, 1, ref deck);
                dealerHandValue = HandValue.GetHandValue(dealerHand);
            }

            Interface.DisplayResult("\nDealer's full hand is:");
            foreach (Card card in dealerHand)
            {
                Interface.DisplayResult(card.ToString());
            }

            // Determine the winner
            if (dealerHandValue > 21)
            {
                Interface.DisplayResult("\nDealer busted! You win.");
            }
            else if (dealerHandValue > playerHandValue)
            {
                Interface.DisplayResult("\nDealer wins.");
            }
            else if (dealerHandValue < playerHandValue)
            {
                Interface.DisplayResult("\nYou win.");
            }
            else
            {
                Interface.DisplayResult("\nIt's a tie.");
            }
        }

    }
}
