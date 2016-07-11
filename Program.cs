using System;

namespace CardProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // initialise new instance if Deck
            Deck myDeck = new Deck();
            // run the shuffle() method in the Deck class
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                // how the cards are displayed
                Console.Write("{0,-19}", myDeck.DealCard());
                if ((i + 1) % 4 == 0) // 4 cards on each line
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
