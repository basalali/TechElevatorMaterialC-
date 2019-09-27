using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] suits = { "H", "D", "C", "S" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            foreach(string suit in suits)
            {
                foreach(string value in values)
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {

        }

        public Card Deal()
        {
            Card result = cards[0];
            cards.RemoveAt(0);
            return result;
        }
    }
}
