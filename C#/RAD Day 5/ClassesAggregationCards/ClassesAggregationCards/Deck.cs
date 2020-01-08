using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAggregationCards
{


    // represents a deck of cards
    class Deck
    {
        // constants
        public int NR_RANKS = 13; // 13 ranks
        public const int NR_SUITS = 4; // 4 suits
        public const int NR_CARDS = 52; // 52 cards in a deck
        private Card[] cards; // array of cards in the deck

        // constructor
        public Deck()
        {
            cards = new Card[NR_CARDS];
            // generate deck of cards
            for (int suitVal = 0; suitVal < NR_SUITS; suitVal++)
            {
                for (int rankVal = 1; rankVal <= NR_RANKS; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                                                                (Rank)rankVal);
                }
            }
        }


        // get a card on position cardNum 
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum < NR_CARDS)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and " + (NR_CARDS - 1).ToString()));
        }

        // shuffle the deck
        public void Shuffle()
        {
            Card[] newDeck = new Card[NR_CARDS]; // auxilliary new deck
            bool[] assigned = new bool[NR_CARDS]; // marks which positions in the new deck are already assigned
            Random sourceGen = new Random(); // random  number generator

            for (int i = 0; i < NR_CARDS; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(NR_CARDS); // randomly generate new position 0..51
                    if (assigned[destCard] == false) // found unassigned spot
                        foundCard = true;
                }
                assigned[destCard] = true; // store the card at the new position
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0); // copy the new deck array over to the original one
        }
    }

}
