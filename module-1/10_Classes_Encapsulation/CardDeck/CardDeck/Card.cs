using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public bool IsFaceUp { get; set; }

        public Card ()
        {
            IsFaceUp = false;
        }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
            IsFaceUp = false;
        }

        public bool Flip()
        {
            IsFaceUp = !IsFaceUp;
            return IsFaceUp;
        }

        public override string ToString()
        {
            return Value + " " + Suit;
        }
    }
}
