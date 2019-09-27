using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card myCard = new Card();
            myCard.Suit = "H";
            myCard.Value = "Q";

            Card myCard2 = new Card("A", "S");

            Console.WriteLine(myCard);
            Console.WriteLine(myCard2);


            Deck myDeck = new Deck();
            Console.WriteLine(myDeck.Deal());

            Console.ReadLine();
        }
    }
}
